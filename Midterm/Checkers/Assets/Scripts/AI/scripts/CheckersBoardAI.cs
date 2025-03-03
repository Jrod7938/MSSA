using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Move {
    public int startX, startY, targetX, targetY;
    public Move(int sX, int sY, int tX, int tY) {
        startX = sX; startY = sY; targetX = tX; targetY = tY;
    }
}

public class CheckersBoardAI : MonoBehaviour {
    public Piece[,] pieces = new Piece[8, 8];

    [Header("Prefabs")]
    public GameObject redPiecePrefab;
    public GameObject redKingPiecePrefab;
    public GameObject blackPiecePrefab;
    public GameObject blackKingPiecePrefab;

    [Header("Board Settings")]
    public bool isRedTurn = true;

    private Vector3 boardOffSet = new Vector3(-4f, 5.411365f, -3.5f);
    private Vector3 pieceOffSet = new Vector3(1.5f, 0, 0.5f);

    public void ResetBoard() {
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 8; y++) {
                if (pieces[x, y] != null) {
                    Destroy(pieces[x, y].gameObject);
                    pieces[x, y] = null;
                }
            }
        }
        isRedTurn = true; 
        for (int y = 0; y < 3; y++) { // red team
            bool oddRow = (y % 2) == 0;
            for (int x = 0; x < 8; x += 2) {
                int posX = oddRow ? x : x + 1;
                if (posX < 8)
                    GeneratePiece(posX, y, true);
            }
        }

        for (int y = 7; y > 4; y--) { // black team
            bool oddRow = (y % 2) == 0;
            for (int x = 0; x < 8; x += 2) {
                int posX = oddRow ? x : x + 1;
                if (posX < 8)
                    GeneratePiece(posX, y, false);
            }
        }
    }

    void GeneratePiece(int x, int y, bool isRed) {
        GameObject pieceObj = isRed
            ? Instantiate(redPiecePrefab, transform)
            : Instantiate(blackPiecePrefab, transform);
        Piece piece = pieceObj.GetComponent<Piece>();
        piece.isRed = isRed;
        piece.isKing = false;
        pieces[x, y] = piece;
        piece.transform.position = (Vector3.right * x) + (Vector3.forward * y) + boardOffSet + pieceOffSet;
    }

    public int[,] GetBoardState() {
        int[,] state = new int[8, 8];
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 8; y++) {
                if (pieces[x, y] == null) {
                    state[x, y] = 0;
                } else {
                    if (pieces[x, y].isRed)
                        state[x, y] = pieces[x, y].isKing ? 2 : 1;
                    else
                        state[x, y] = pieces[x, y].isKing ? -2 : -1;
                }
            }
        }
        return state;
    }

    public List<Move> GetValidMoves(bool forRed) {
        List<Move> validMoves = new List<Move>();
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 8; y++) {
                Piece piece = pieces[x, y];
                if (piece != null && piece.isRed == forRed) {
                    int[,] directions = new int[,] { { 1, 1 }, { -1, 1 }, { 1, -1 }, { -1, -1 } };
                    for (int d = 0; d < directions.GetLength(0); d++) {
                        int dx = directions[d, 0];
                        int dy = directions[d, 1];
                        int targetX = x + dx;
                        int targetY = y + dy;
                        if (targetX >= 0 && targetX < 8 && targetY >= 0 && targetY < 8) {
                            if (piece.ValidMove(pieces, x, y, targetX, targetY)) {
                                validMoves.Add(new Move(x, y, targetX, targetY));
                            }
                        }
                    }
                    int[,] captureDirections = new int[,] { { 2, 2 }, { -2, 2 }, { 2, -2 }, { -2, -2 } };
                    for (int d = 0; d < captureDirections.GetLength(0); d++) {
                        int dx = captureDirections[d, 0];
                        int dy = captureDirections[d, 1];
                        int targetX = x + dx;
                        int targetY = y + dy;
                        if (targetX >= 0 && targetX < 8 && targetY >= 0 && targetY < 8) {
                            if (piece.ValidMove(pieces, x, y, targetX, targetY)) {
                                validMoves.Add(new Move(x, y, targetX, targetY));
                            }
                        }
                    }
                }
            }
        }
        return validMoves;
    }

    public float ExecuteMove(Move move) {
        float reward = 0f;
        int x1 = move.startX, y1 = move.startY, x2 = move.targetX, y2 = move.targetY;
        Piece selectedPiece = pieces[x1, y1];
        if (selectedPiece == null)
            return -0.1f;
        if (!selectedPiece.ValidMove(pieces, x1, y1, x2, y2))
            return -0.1f;
        if (Mathf.Abs(x2 - x1) == 2) {
            int capX = (x1 + x2) / 2;
            int capY = (y1 + y2) / 2;
            if (pieces[capX, capY] != null) {
                Destroy(pieces[capX, capY].gameObject);
                pieces[capX, capY] = null;
                reward += 0.5f;
            }
        }
        pieces[x2, y2] = selectedPiece;
        pieces[x1, y1] = null;
        selectedPiece.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;
        if (selectedPiece.isRed && !selectedPiece.isKing && y2 == 7) {
            Destroy(selectedPiece.gameObject);
            GameObject newKing = Instantiate(redKingPiecePrefab, transform);
            Piece kingComponent = newKing.GetComponent<Piece>();
            kingComponent.isRed = true;
            kingComponent.isKing = true;
            pieces[x2, y2] = kingComponent;
            kingComponent.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;
        } else if (!selectedPiece.isRed && !selectedPiece.isKing && y2 == 0) {
            Destroy(selectedPiece.gameObject);
            GameObject newKing = Instantiate(blackKingPiecePrefab, transform);
            Piece kingComponent = newKing.GetComponent<Piece>();
            kingComponent.isRed = false;
            kingComponent.isKing = true;
            pieces[x2, y2] = kingComponent;
            kingComponent.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;
        }
        reward += 0.1f;
        isRedTurn = !isRedTurn;
        return reward;
    }

    public int CheckVictory() {
        bool hasRed = false, hasBlack = false;
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 8; y++) {
                if (pieces[x, y] != null) {
                    if (pieces[x, y].isRed)
                        hasRed = true;
                    else
                        hasBlack = true;
                }
            }
        }
        if (!hasRed) return -1;
        if (!hasBlack) return 1;
        return 0;
    }
}
