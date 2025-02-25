using UnityEngine;

public class CheckersBoard : MonoBehaviour
{
    Piece[,] pieces = new Piece[8,8];

    public GameObject redPiecePrefab;
    public GameObject blackPiecePrefab;

    private Vector3 boardOffSet = new Vector3(-4f, 5.411365f, -3.5f);
    private Vector3 pieceOffSet = new Vector3(1.5f, 0, .5f);

    private Vector2 mouseOver;

    private void Start()
    {
        GenerateBoard();
    }

    private void Update()
    {
        UpdateMouseOver();
        Debug.Log($"Mouse: {mouseOver}");
    }

    private void UpdateMouseOver(){
        if(!Camera.main){
            Debug.Log("Unable to find Main Camera");
            return;
        }

        RaycastHit hit;
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("Board"))){
            mouseOver.x = (int)(hit.point.x - boardOffSet.x) - 1;
            mouseOver.y = (int)(hit.point.z - boardOffSet.z);
        } else {
            mouseOver.x = -1;
            mouseOver.y = -1;
        }
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
