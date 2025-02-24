using UnityEngine;
using System.Collections.Generic;

public class Piece : MonoBehaviour
{
    public bool isKing { get; private set; }
    public bool isPlayerOne { get; private set; } // True = Red, False = Black

    public Vector2Int boardPosition { get; private set; }

    private BoardManager boardManager;

    private void Start()
    {
        boardManager = BoardManager.Instance;
    }

    public void Initialize(bool isPlayerOne, Vector2Int startPos)
    {
        this.isPlayerOne = isPlayerOne;
        this.boardPosition = startPos;
    }

    public List<Vector2Int> GetValidMoves()
    {
        List<Vector2Int> moves = new List<Vector2Int>();

        // Basic forward direction (red = +1, black = -1)
        int dir = isPlayerOne ? 1 : -1;

        // Potential moves: one step diagonals
        Vector2Int left = boardPosition + new Vector2Int(-1, dir);
        Vector2Int right = boardPosition + new Vector2Int(1, dir);

        // If they're on the board and unoccupied, add them
        if (IsOnBoard(left) && IsEmpty(left)) moves.Add(left);
        if (IsOnBoard(right) && IsEmpty(right)) moves.Add(right);

        // Check for possible captures (jump two diagonals)
        Vector2Int leftJump = boardPosition + new Vector2Int(-2, dir * 2);
        Vector2Int rightJump = boardPosition + new Vector2Int(2, dir * 2);

        // If an enemy piece is diagonal, and landing spot is free, add jump
        if (CanCapture(left, leftJump)) moves.Add(leftJump);
        if (CanCapture(right, rightJump)) moves.Add(rightJump);

        return moves;
    }

    private bool IsOnBoard(Vector2Int pos)
    {
        return pos.x >= 0 && pos.x < 8 && pos.y >= 0 && pos.y < 8;
    }

    private bool IsEmpty(Vector2Int pos)
    {
        Piece p = BoardManager.Instance.GetPieceAt(pos.x, pos.y);
        return (p == null);
    }

    private bool CanCapture(Vector2Int adjacent, Vector2Int landing)
    {
        if (!IsOnBoard(adjacent) || !IsOnBoard(landing)) return false;
        Piece midPiece = BoardManager.Instance.GetPieceAt(adjacent.x, adjacent.y);

        if (midPiece == null) return false;           // nothing to capture
        if (midPiece.isPlayerOne == this.isPlayerOne) return false; // same color
        if (!IsEmpty(landing)) return false;          // must land on empty space

        return true;
    }



    public void Move(Vector2Int newPosition)
    {
        // Remove piece from its old spot in the board array
        boardManager.ClearPiece(boardPosition);

        // Update board position
        boardPosition = newPosition;

        // Move GameObject
        transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.y);

        // Place this piece in the board array
        boardManager.SetPiece(this, newPosition);
    }


    // Promote piece to King
    public void PromoteToKing()
    {
        isKing = true;
        // Change model to King (handled in a future method)
    }
}
