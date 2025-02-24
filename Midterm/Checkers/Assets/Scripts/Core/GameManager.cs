using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isPlayerOneTurn = true;

    private void Awake()
    {
        Instance = this;
    }

    public void EndTurn()
    {
        isPlayerOneTurn = !isPlayerOneTurn;

        // Move AI
    }

    public void CheckForWinCondition()
    {
        bool redExists = false;
        bool blackExists = false;

        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                Piece piece = BoardManager.Instance.GetPieceAt(x, y);
                if (piece != null)
                {
                    if (piece.isPlayerOne) redExists = true;
                    else blackExists = true;

                    // If both exist, no winner 
                    if (redExists && blackExists) return;
                }
            }
        }

        if (!redExists) // Black wins
        {
            Debug.Log("Black Wins!");
        }
        else if (!blackExists) // Red wins
        {
            Debug.Log("Red Wins!");
        }
    }
}
