using System;
using System.Collections.Generic;
using UnityEngine;

public class CheckersBoard : MonoBehaviour
{
    Piece[,] pieces = new Piece[8,8];

    public GameObject redPiecePrefab;
    public GameObject redKingPiecePrefab;
    public GameObject blackPiecePrefab;
    public GameObject blackKingPiecePrefab;

    private Vector3 boardOffSet = new Vector3(-4f, 5.411365f, -3.5f);
    private Vector3 pieceOffSet = new Vector3(1.5f, 0, .5f);

    public bool isRed;
    private bool isRedTurn;
    private bool hasKilled;

    private Piece selectedPiece;
    private List<Piece> forcedPieces;

    private Vector2 mouseOver;
    private Vector2 startDrag;
    private Vector2 endDrag;

    private void Start()
    {
        isRedTurn = true;
        forcedPieces = new List<Piece>();
        GenerateBoard();
    }

    private void Update()
    {
        UpdateMouseOver();
        
        // if my turn
        if((isRed)? isRedTurn : !isRedTurn){
            int x = (int)mouseOver.x;
            int y = (int)mouseOver.y;

            if(selectedPiece != null) UpdatePieceDrag(selectedPiece);

            // Debug.Log($"Mouse: {x} {y}");
            if(Input.GetMouseButtonDown(0)){
                SelectPiece(x, y);
            }

            if (Input.GetMouseButtonUp(0)) {
                TryMove((int)startDrag.x, (int)startDrag.y, x, y);
            }
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

    private void UpdatePieceDrag(Piece piece){
        if(!Camera.main){
            Debug.Log("Unable to find Main Camera");
            return;
        }

        RaycastHit hit;
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("Board"))){
            piece.transform.position = hit.point + Vector3.up;
        } 
    }

    private void SelectPiece(int x, int y){
        if(x < 0 || x >= 8 || y < 0 || y >= 8) return;
        
        Piece piece = pieces[x, y];
        if(piece != null && piece.isRed == isRed){
            if(forcedPieces.Count == 0){
                selectedPiece = piece;
                startDrag = mouseOver;
                
            }else{
                if(forcedPieces.Find(fp => fp == piece) == null) return; // search for piece
                selectedPiece = piece;
                startDrag = mouseOver;
            }
            
        }
    }

    private void TryMove(int x1, int y1, int x2, int y2) {
        forcedPieces = ScanForPossibleMove();
        
        startDrag = new Vector2(x1, y1);
        endDrag = new Vector2(x2, y2);

        selectedPiece = pieces[x1, y1];

        if(x2 < 0 || x2 >= 8 || y2 < 0 || y2 >= 8) { // out of bounds
            if(selectedPiece != null) MovePiece(selectedPiece, x1, y1);

            startDrag = Vector2.zero;
            selectedPiece = null;
            return;
        }
        if(selectedPiece != null){
            if(endDrag == startDrag){ // has not moved
                MovePiece(selectedPiece, x1, y1);
                startDrag = Vector2.zero;
                selectedPiece = null;
                return;
            }

            if(selectedPiece.ValidMove(pieces, x1, y1, x2, y2)){ // check valid move
                if(Mathf.Abs(x2 - x1) == 2){ // capture 
                    Piece capturePiece = pieces[(x1 + x2) / 2, (y1 + y2) / 2];
                    if(capturePiece != null){
                        pieces[(x1 + x2) / 2, (y1 + y2) / 2] = null;
                        Destroy(capturePiece.gameObject);
                        hasKilled = true;
                    }
                }

                if(forcedPieces.Count != 0 && !hasKilled) { // were we supposed to kill something
                    MovePiece(selectedPiece, x1, y1);
                    startDrag = Vector2.zero;
                    selectedPiece = null;
                    return;
                }

                pieces[x2, y2] = selectedPiece;
                pieces[x1, y1] = null;
                MovePiece(selectedPiece, x2, y2);

                EndTurn();
            } else {
                MovePiece(selectedPiece, x1, y1);
                startDrag = Vector2.zero;
                selectedPiece = null;
                return;
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

    private void EndTurn(){
        int x = (int)endDrag.x;
        int y = (int)endDrag.y;

        if(selectedPiece.isRed && !selectedPiece.isKing && y == 7){ // should we "king" a red piece?
            Destroy(selectedPiece.gameObject);
            GameObject newKing = Instantiate(redKingPiecePrefab, transform);
            Piece kingComponent = newKing.GetComponent<Piece>();
            kingComponent.isRed = true;
            kingComponent.isKing = true;
            pieces[x, y] = kingComponent;
            MovePiece(kingComponent, x, y);
        } else if(!selectedPiece.isRed && !selectedPiece.isKing && y == 0){ // should we "king" a black piece
            Destroy(selectedPiece.gameObject);
            GameObject newKing = Instantiate(blackKingPiecePrefab, transform);
            Piece kingComponent = newKing.GetComponent<Piece>();
            kingComponent.isRed = false;
            kingComponent.isKing = true;
            pieces[x, y] = kingComponent;
            MovePiece(kingComponent, x, y);
        }

        selectedPiece = null;
        startDrag = Vector2.zero;

        if(ScanForPossibleMove(selectedPiece, x, y).Count != 0 && hasKilled) return; // can you will another?

        isRedTurn = !isRedTurn;
        hasKilled = false;
        CheckVictory();
    }

    private void CheckVictory(){
        var ps = FindObjectsByType<Piece>(FindObjectsSortMode.None);
        bool hasRed = false;
        bool hasBlack = false;
        for(int i = 0; i < ps.Length; i++){
            if(ps[i].isRed){
                hasRed = true;
            }else{
                hasBlack = true;
            }
        }

        if(!hasRed) Victory(false);
        if(!hasBlack) Victory(true);
    }

    private void Victory(bool isRed){
        if(isRed){
            Debug.Log("Red Team Won.");
        } else {
            Debug.Log("Black Team Won.");
        }
    }

    private List<Piece> ScanForPossibleMove(Piece piece, int x, int y){
        forcedPieces = new List<Piece>();

        if(pieces[x, y].IsForcedToMove(pieces, x, y)){
            forcedPieces.Add(pieces[x, y]);
        }

        return forcedPieces;
    }

    private List<Piece> ScanForPossibleMove(){
        forcedPieces = new List<Piece>();

        for(int i = 0; i < 8; i++){
            for(int j = 0; j < 8; j++){
                if(pieces[i,j] != null && pieces[i,j].isRed == isRedTurn){
                    if(pieces[i, j].IsForcedToMove(pieces, i, j)){
                        forcedPieces.Add(pieces[i, j]);
                    }
                }
            }
        }
        return forcedPieces;
    }
}
