using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerState playerState;
    public LevelState levelState;
    public PieceState pieceState;
    public static int collectedPiece;
    public static int totalPiece;

    void Start() {
        collectedPiece=0;    
        totalPiece=0;
        pieceState=PieceState.Pawn;
        levelState=PlayerManager.LevelState.NotFinished;
        playerState=PlayerManager.PlayerState.Stop;
    }
    public enum PieceState{
        Pawn,
        Knight,
        Bishop,
        Rook,
        Quenn,
        King
    }
    public enum PlayerState{
        Stop,
        Move,
        Finish
    }
    public enum LevelState{
        NotFinished,
        Finished
    }
}
