using UnityEngine;

public class CheckersBoard : MonoBehaviour
{
    Piece[,] pieces = new Piece[8,8];

    public GameObject redPiecePrefab;
    public GameObject blackPiecePrefab;

    private Vector3 boardOffSet = new Vector3(-4f, 5.6f, -4f);
    private Vector3 pieceOffSet = new Vector3(1.5f, 0, 1f);

    private void Start()
    {
        GenerateBoard();
    }

    private void GenerateBoard(){
        for(int y = 0; y < 3; y++){ // red team
            bool oddRow = (y % 2) == 0;
            for(int x = 0; x < 8; x += 2){
                GeneratePiece((oddRow) ? x : x + 1, y);
            }
        }

        for(int y = 7; y > 4; y--){ // black team
            bool oddRow = (y % 2) == 0;
            for(int x = 0; x < 8; x += 2){
                GeneratePiece((oddRow) ? x : x + 1, y);
            }
        }
    }

    private void GeneratePiece(int x, int y){
        bool isRed = (y > 3) ? false : true;
        GameObject piece = Instantiate((isRed) ? redPiecePrefab : blackPiecePrefab, transform);
        Piece p = piece.GetComponent<Piece>();

        pieces[x, y] = p;
        MovePiece(p, x, y);
    }

    private void MovePiece(Piece piece, int x, int y){
        piece.transform.position = (Vector3.right * x) + (Vector3.forward * y) + boardOffSet + pieceOffSet;
    }
}
