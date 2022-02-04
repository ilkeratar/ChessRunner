using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] CinemachineVirtualCamera cam1;
    [SerializeField] CinemachineVirtualCamera cam2;
    [SerializeField] GameObject piece;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
            StartCoroutine(AddForceToKing());
            
            
        }
         
    }

    private IEnumerator AddForceToKing(){
        playerManager.playerState=PlayerManager.PlayerState.Finish;
        yield return new WaitForSeconds(1f);
        piece.GetComponent<Animator>().SetBool("isFinish",true);
    }
    
       
    
}
