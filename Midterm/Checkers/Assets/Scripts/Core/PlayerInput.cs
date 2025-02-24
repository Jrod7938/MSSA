using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Piece selectedPiece;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // If clicked on a piece
                Piece piece = hit.collider.GetComponent<Piece>();
                if (piece != null)
                {
                    if (piece.isPlayerOne == GameManager.Instance.isPlayerOneTurn)
                    {
                        selectedPiece = piece;
                    }
                }
                else
                {
                    // If clicked on board, try moving selected piece
                    if (selectedPiece != null)
                    {
                        float boardOffsetX = 2.5f;
                        float boardOffsetZ = 3.0f;

                        Vector2Int targetPos = new Vector2Int(
                            Mathf.RoundToInt(hit.point.x - boardOffsetX),
                            Mathf.RoundToInt(hit.point.z - boardOffsetZ)
                        );

                        TryMove(selectedPiece, targetPos);
                    }
                }
            }
        }
    }

    void TryMove(Piece piece, Vector2Int target)
    {
        // Basic validation
        var validMoves = piece.GetValidMoves();
        if (validMoves.Contains(target))
        {
            piece.Move(target);
            GameManager.Instance.EndTurn();
        }
        selectedPiece = null;
    }
}
