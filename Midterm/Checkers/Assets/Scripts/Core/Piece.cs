using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public bool isRed;
    public bool isKing;

    public bool IsForcedToMove(Piece[,] board, int x, int y){
        if(isRed || isKing){  
            if(x >= 2 && y <= 5){ // top left
                Piece piece = board[x - 1, y + 1];
                if(piece != null && piece.isRed != isRed){
                    if(board[x - 2, y + 2] == null){
                        return true;
                    }
                }
            }

            if(x <= 5 && y <= 5){ // top right
                Piece piece = board[x + 1, y + 1];
                if(piece != null && piece.isRed != isRed){
                    if(board[x + 2, y + 2] == null){
                        return true;
                    }
                }
            }
        } 
        
        if(!isRed || isKing) {
            if(x >= 2 && y >= 2){ // bottom left
                Piece piece = board[x - 1, y - 1];
                if(piece != null && piece.isRed != isRed){
                    if(board[x - 2, y - 2] == null){
                        return true;
                    }
                }
            }

            if(x <= 5 && y >= 2){ // bottom right
                Piece piece = board[x + 1, y - 1];
                if(piece != null && piece.isRed != isRed){
                    if(board[x + 2, y - 2] == null){
                        return true;
                    }
                }
            }
        }

        return false;
    }

    public bool ValidMove(Piece[,] board, int x1, int y1, int x2, int y2){
        // moving on top of another piece
        if(board[x2,y2] != null) return false;


        int deltaMoveX = Math.Abs(x1 - x2);
        int deltaMoveY = y2 - y1;

        if(isRed || isKing){ // red team
            if(deltaMoveX == 1){ // regular movement
                if(deltaMoveY == 1) return true;
            }else if(deltaMoveX == 2){ // capture movement
                if(deltaMoveY == 2){
                    Piece capturePiece = board[(x1 + x2) / 2, (y1 + y2) / 2];
                    if(capturePiece != null && capturePiece.isRed != isRed) return true;
                }
            }
        }

        if(!isRed || isKing){ // black team
            if(deltaMoveX == 1){ // regular movement
                if(deltaMoveY == -1) return true;
            }else if(deltaMoveX == 2){ // capture movement
                if(deltaMoveY == -2){
                    Piece capturePiece = board[(x1 + x2) / 2, (y1 + y2) / 2];
                    if(capturePiece != null && capturePiece.isRed != isRed) return true;
                }
            }
        }

        return false;
    }
}
