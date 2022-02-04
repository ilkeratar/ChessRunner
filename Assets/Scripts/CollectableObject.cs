using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    private Vector3 toMid,toBig;
    void Start() {
        toMid=new Vector3(5f,5f,5f); 
        toBig=new Vector3(7f,7f,7f);
    }
    void Update(){
        transform.Rotate(0,0,50*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player")
        {  
            PlayerManager.collectedPiece+=1;
            PlayerManager.totalPiece+=1;
            if(PlayerManager.collectedPiece==2){
            other.transform.localScale+=toMid;
            }else if (PlayerManager.collectedPiece==4){
            other.transform.localScale+=toBig;
            }else if(PlayerManager.collectedPiece==6){
             var temp = other.GetComponentInParent<PieceManager>();
             temp.ChangePiece();

            }
            Debug.Log(PlayerManager.collectedPiece);
            Destroy(transform.parent.gameObject);
        }

        
    }

    
}
