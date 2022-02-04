using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField]  Transform Pawn;
    [SerializeField]  Transform Knight;
    [SerializeField] Transform Bishop;
    [SerializeField] Transform Rook;
    [SerializeField] Transform Quenn;
    [SerializeField] Transform King;


public void ChangePiece(){
        switch (playerManager.pieceState)
        {
            case (PlayerManager.PieceState.Pawn):
                MakeKnight();
                
                break;
            case (PlayerManager.PieceState.Knight):
                MakeBishop();
                break;
            case (PlayerManager.PieceState.Bishop):
                MakeRook();
                break;
            case (PlayerManager.PieceState.Rook):
                MakeQuenn();
                break;
            case (PlayerManager.PieceState.Quenn):
                MakeKing();
                break;

            default:
                break;
                
        }
    }
    
    public void MakeKnight(){
        Pawn.gameObject.SetActive(false);
        Knight.localScale=new Vector3(13f,13f,13f);
        Knight.gameObject.SetActive(true);
        playerManager.pieceState=PlayerManager.PieceState.Knight;
        PlayerManager.collectedPiece=0;
    }
    public void MakeBishop(){
        Knight.gameObject.SetActive(false);
        Bishop.localScale=new Vector3(13f,13f,13f);
        Bishop.gameObject.SetActive(true);
        playerManager.pieceState=PlayerManager.PieceState.Bishop;
        PlayerManager.collectedPiece=0;
    }
    public void MakeRook(){
        Bishop.gameObject.SetActive(false);
        Rook.localScale=new Vector3(13f,13f,13f);
        Rook.gameObject.SetActive(true);
        playerManager.pieceState=PlayerManager.PieceState.Rook;
        PlayerManager.collectedPiece=0;
    }
    public void MakeQuenn(){
        Rook.gameObject.SetActive(false);
        Quenn.localScale=new Vector3(13f,13f,13f);
        Quenn.gameObject.SetActive(true);
        playerManager.pieceState=PlayerManager.PieceState.Quenn;
        PlayerManager.collectedPiece=0;
    }
    public void MakeKing(){
        Quenn.gameObject.SetActive(false);
        King.localScale=new Vector3(13f,13f,13f);
        King.gameObject.SetActive(true);
        playerManager.pieceState=PlayerManager.PieceState.King;
        PlayerManager.collectedPiece=0;
    }

    
        

}
