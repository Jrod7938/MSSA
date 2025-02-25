using System;
using UnityEngine;

public class CheckersBoard : MonoBehaviour
{
    Piece[,] pieces = new Piece[8,8];

    public GameObject redPiecePrefab;
    public GameObject blackPiecePrefab;

    private Vector3 boardOffSet = new Vector3(-4f, 5.411365f, -3.5f);
    private Vector3 pieceOffSet = new Vector3(1.5f, 0, .5f);

    private Piece selectedPiece;

    private Vector2 mouseOver;
    private Vector2 startDrag;
    private Vector2 endDrag;

    private void Start()
    {
        GenerateBoard();
    }

    private void Update()
    {
        UpdateMouseOver();
        
        // if my turn
        {
            int x = (int)mouseOver.x;
            int y = (int)mouseOver.y;

            // Debug.Log($"Mouse: {x} {y}");
            if(Input.GetMouseButtonDown(0)){
                SelectPiece(x, y);
            }

            if (Input.GetMouseButtonUp(0)) {
                TryMove((int)startDrag.x, (int)startDrag.y, x, y);
            }
        }
    }

    private void TryMove(int x1, int y1, int x2, int y2) {
        startDrag = new Vector2(x1, y1);
        endDrag = new Vector2(x2, y2);

        selectedPiece = pieces[x1, y1];

        MovePiece(selectedPiece, x2, y2);
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

    private void SelectPiece(int x, int y){
        if(x < 0 || x >= pieces.Length || y < 0 || y >= pieces.Length) return;
        
        Piece piece = pieces[x, y];
        if(piece != null){
            selectedPiece = piece;
            startDrag = mouseOver;
            Debug.Log(selectedPiece.name);
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
