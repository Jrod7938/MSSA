using System;
using UnityEngine;

public class BoardManager : MonoBehaviour
{

    public static BoardManager Instance;

    public GameObject checkerBoard;
    public GameObject redPiece;
    public GameObject redKing;
    public GameObject blackPiece;
    public GameObject blackKing;


    private Piece[,] board = new Piece[8, 8];

    public void Awake()
    {
        Instance = this;
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        Instantiate(checkerBoard, new Vector3(2.5f, 0, 3), Quaternion.identity); // create board

        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                if ((x + y) % 2 == 1)
                { // only place on black
                    if (y < 3) SpawnPiece(redPiece, x, y);
                    if (y > 4) SpawnPiece(blackPiece, x, y);
                }
            }
        }
    }

    private void SpawnPiece(GameObject piecePrefab, int x, int y)
    {
        GameObject pieceObject = Instantiate(piecePrefab, new Vector3(x, 6, y), Quaternion.identity);
        Piece piece = pieceObject.GetComponent<Piece>();

        // Determine color based on prefab used:
        bool isPlayerOne = (piecePrefab == redPiece || piecePrefab == redKing);

        // Assign the piece's color and board position
        piece.Initialize(isPlayerOne, new Vector2Int(x, y));

        board[x, y] = piece;
    }

    public void SetPiece(Piece piece, Vector2Int pos)
    {
        board[pos.x, pos.y] = piece;
    }

    public void ClearPiece(Vector2Int pos)
    {
        board[pos.x, pos.y] = null;
    }

    public Piece GetPieceAt(int x, int y)
    {
        return board[x, y];
    }

}
