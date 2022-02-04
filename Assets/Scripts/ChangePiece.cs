using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePiece : MonoBehaviour
{
    [SerializeField]  Transform Pawn;
    [SerializeField]  Transform Knight;
    [SerializeField] Transform Bishop;
    [SerializeField] Transform Rook;
    [SerializeField] Transform Quenn;
    [SerializeField] Transform King;

    private void Start() {
        int rand=Random.Range(0,100);
        if(rand<20){
            Pawn.gameObject.SetActive(true);
        }
        else if(rand>=20 && rand<40){
            Knight.gameObject.SetActive(true);
        }
        else if(rand>=40 && rand<55){
            Bishop.gameObject.SetActive(true);
        }
        else if(rand>=55 && rand<70){
            Rook.gameObject.SetActive(true);
        }
        else if(rand>=70 && rand<85){
            Quenn.gameObject.SetActive(true);
        }
        else if(rand>=85){
            King.gameObject.SetActive(true);
        }

    }

}
