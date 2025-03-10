using System.Collections.Generic;
using TMPro;
using UnityEngine;

[System.Serializable]
public struct Move {
    public int startX, startY, targetX, targetY;
    public Move(int sX, int sY, int tX, int tY) {
        startX = sX; startY = sY; targetX = tX; targetY = tY;
    }
}

public class CheckersBoardAI : MonoBehaviour, ICheckersBoard {
    public Piece[,] pieces = new Piece[8, 8];

    [Header("Prefabs")]
    public GameObject redPiecePrefab;
    public GameObject redKingPiecePrefab;
    public GameObject blackPiecePrefab;
    public GameObject blackKingPiecePrefab;

    [Header("Board Settings")]
    public bool isRedTurn { get; set; } = true;

    private Vector3 boardOffSet = new Vector3(-4f, 5.411365f, -3.5f);
    private Vector3 pieceOffSet = new Vector3(1.5f, 0, 0.5f);

    private Piece chainCapturePiece = null;

    public int redScore = 0;
    public int blackScore = 0;
    public TMP_Text redScoreText;
    public TMP_Text blackScoreText;

    /// <summary>
    /// Resets the board by clearing existing pieces and reinitializing it with 
    /// red and black pieces in their starting positions
    /// </summary>
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
        chainCapturePiece = null;
        // Set up red pieces
        for (int y = 0; y < 3; y++) {
            bool oddRow = (y % 2) == 0;
            for (int x = 0; x < 8; x += 2) {
                int posX = oddRow ? x : x + 1;
                if (posX < 8)
                    GeneratePiece(posX, y, true);
            }
        }
        // Set up black pieces
        for (int y = 7; y > 4; y--) {
            bool oddRow = (y % 2) == 0;
            for (int x = 0; x < 8; x += 2) {
                int posX = oddRow ? x : x + 1;
                if (posX < 8)
                    GeneratePiece(posX, y, false);
            }
        }
    }

    /// <summary>
    /// Instantiates and places a new piece on the board at the specified coordinates, 
    /// setting its team based on the provided flag
    /// </summary>
    /// <param name="x">The x-coordinate on the board</param>
    /// <param name="y">The y-coordinate on the board</param>
    /// <param name="isRed">Determines if the piece belongs to the red team</param>
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

    /// <summary>
    /// Retrieves the current state of the board as a two-dimensional integer array,
    /// where each integer represents the state of a cell
    /// </summary>
    /// <returns>
    /// A 2D integer array where 0 indicates an empty cell, 1 (or 2 for kings) indicates 
    /// a red piece, and -1 (or -2 for kings) indicates a black piece
    /// </returns>
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

    /// <summary>
    /// Computes and returns all valid moves for the specified team, including forced 
    /// capture moves and regular moves, while also handling chain-capture conditions
    /// </summary>
    /// <param name="forRed">
    /// If true, computes moves for red pieces; otherwise, for  black pieces
    /// </param>
    /// <returns>A list of valid moves available to the specified team</returns>
    public List<Move> GetValidMoves(bool forRed) {
        List<Move> validMoves = new List<Move>();
        List<Move> forcedMoves = new List<Move>();

        // If a chain capture is active, only allow moves for that piece.
        if (chainCapturePiece != null) {
            int x = -1, y = -1;
            // Find the location of the chain capture piece.
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (pieces[i, j] == chainCapturePiece) {
                        x = i;
                        y = j;
                        break;
                    }
                }
                if (x != -1) break;
            }
            if (x != -1 && y != -1) {
                int[,] captureDirections = new int[,] { { 2, 2 }, { -2, 2 }, { 2, -2 }, { -2, -2 } };
                for (int d = 0; d < captureDirections.GetLength(0); d++) {
                    int dx = captureDirections[d, 0];
                    int dy = captureDirections[d, 1];
                    int targetX = x + dx;
                    int targetY = y + dy;
                    if (targetX >= 0 && targetX < 8 && targetY >= 0 && targetY < 8) {
                        if (chainCapturePiece.ValidMove(pieces, x, y, targetX, targetY)) {
                            forcedMoves.Add(new Move(x, y, targetX, targetY));
                        }
                    }
                }
            }
            ShuffleList(forcedMoves);
            return forcedMoves;
        }

        // First, search for forced (capture) moves for all pieces.
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 8; y++) {
                Piece piece = pieces[x, y];
                if (piece != null && piece.isRed == forRed) {
                    if (piece.IsForcedToMove(pieces, x, y)) {
                        int[,] captureDirections = new int[,] { { 2, 2 }, { -2, 2 }, { 2, -2 }, { -2, -2 } };
                        for (int d = 0; d < captureDirections.GetLength(0); d++) {
                            int dx = captureDirections[d, 0];
                            int dy = captureDirections[d, 1];
                            int targetX = x + dx;
                            int targetY = y + dy;
                            if (targetX >= 0 && targetX < 8 && targetY >= 0 && targetY < 8) {
                                if (piece.ValidMove(pieces, x, y, targetX, targetY)) {
                                    forcedMoves.Add(new Move(x, y, targetX, targetY));
                                }
                            }
                        }
                    }
                }
            }
        }
        if (forcedMoves.Count > 0) {
            ShuffleList(forcedMoves);
            return forcedMoves;
        }

        // Otherwise, return all valid regular moves.
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
                }
            }
        }
        ShuffleList(validMoves);
        return validMoves;
    }

    /// <summary>
    /// Randomly shuffles the elements of the provided list using the Fisher Yates algorithm
    /// </summary>
    /// <typeparam name="T">The type of elements in the list</typeparam>
    /// <param name="list">The list to shuffle</param>
    private void ShuffleList<T>(List<T> list) {
        for (int i = list.Count - 1; i > 0; i--) {
            int rnd = Random.Range(0, i + 1);
            T temp = list[i];
            list[i] = list[rnd];
            list[rnd] = temp;
        }
    }

    /// <summary>
    /// Executes a move on the board by updating piece positions, handling captures and 
    /// promotions, and returns a reward value indicating the outcome of the move
    /// </summary>
    /// <param name="move">The move to execute, containing starting and target coordinates</param>
    /// <returns>A float representing the reward for executing the move</returns>
    public float ExecuteMove(Move move) {
        float reward = 0f;
        int x1 = move.startX, y1 = move.startY, x2 = move.targetX, y2 = move.targetY;
        Piece selectedPiece = pieces[x1, y1];
        if (selectedPiece == null)
            return -0.1f;
        if (!selectedPiece.ValidMove(pieces, x1, y1, x2, y2))
            return -0.1f;
        bool wasCapture = false;
        if (Mathf.Abs(x2 - x1) == 2) {
            int capX = (x1 + x2) / 2;
            int capY = (y1 + y2) / 2;
            if (pieces[capX, capY] != null) {
                Destroy(pieces[capX, capY].gameObject);
                pieces[capX, capY] = null;
                reward += 0.5f;
                wasCapture = true;
            }
        }
        // Move the piece.
        pieces[x2, y2] = selectedPiece;
        pieces[x1, y1] = null;
        selectedPiece.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;

        // Promotion check.
        if (selectedPiece.isRed && !selectedPiece.isKing && y2 == 7) {
            Destroy(selectedPiece.gameObject);
            GameObject newKing = Instantiate(redKingPiecePrefab, transform);
            Piece kingComponent = newKing.GetComponent<Piece>();
            kingComponent.isRed = true;
            kingComponent.isKing = true;
            pieces[x2, y2] = kingComponent;
            kingComponent.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;
            selectedPiece = kingComponent;
        } else if (!selectedPiece.isRed && !selectedPiece.isKing && y2 == 0) {
            Destroy(selectedPiece.gameObject);
            GameObject newKing = Instantiate(blackKingPiecePrefab, transform);
            Piece kingComponent = newKing.GetComponent<Piece>();
            kingComponent.isRed = false;
            kingComponent.isKing = true;
            pieces[x2, y2] = kingComponent;
            kingComponent.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;
            selectedPiece = kingComponent;
        }
        reward += 0.1f;

        // Chain-capture logic:
        if (wasCapture && selectedPiece.IsForcedToMove(pieces, x2, y2)) {
            // Remain in chain capture mode.
            chainCapturePiece = selectedPiece;
        } else {
            chainCapturePiece = null;
            isRedTurn = !isRedTurn;
        }
        return reward;
    }

    /// <summary>
    /// Checks for victory by verifying if either team has no remaining pieces, updates scores accordingly,
    /// and refreshes the score UI
    /// </summary>
    /// <returns>
    /// Returns -1 if red loses (black wins), 1 if black loses (red wins), or 0 if no victory condition is met
    /// </returns>
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
        if (!hasRed) {
            blackScore++;
            UpdateScoreUI();
            return -1;
        }
        if (!hasBlack) {
            redScore++;
            UpdateScoreUI();
            return 1; 
        }
        return 0;
    }

    /// <summary>
    /// Updates the score display UI to reflect the current scores of both the red and black teams 
    /// </summary>
    private void UpdateScoreUI() {
        redScoreText.text = redScore.ToString();
        blackScoreText.text = blackScore.ToString();
    }

}
