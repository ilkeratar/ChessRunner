using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class GameUI : MonoBehaviour
{
    [SerializeField] Text holdtxt;
    [SerializeField] PlayerManager playerManager;
    [SerializeField] Rigidbody pawnrb;
    [SerializeField] GameObject homeui;
    [SerializeField] Slider slider;
    [SerializeField] GameObject gameui;
    private bool isTouching;
    void Start()
    {
        isTouching=false;
        holdtxt.DOFade(1,1);
    }
    void Update() {
        switch (playerManager.pieceState)
        {
            case (PlayerManager.PieceState.Knight):
                slider.transform.GetChild(2).gameObject.SetActive(false);
                slider.transform.GetChild(3).gameObject.SetActive(true);
                slider.transform.GetChild(7).gameObject.SetActive(false);
                slider.transform.GetChild(8).gameObject.SetActive(true);
                break;
            case (PlayerManager.PieceState.Bishop):
                slider.transform.GetChild(3).gameObject.SetActive(false);
                slider.transform.GetChild(4).gameObject.SetActive(true);
                slider.transform.GetChild(8).gameObject.SetActive(false);
                slider.transform.GetChild(9).gameObject.SetActive(true);
                break;
            case (PlayerManager.PieceState.Rook):
                slider.transform.GetChild(4).gameObject.SetActive(false);
                slider.transform.GetChild(5).gameObject.SetActive(true);
                slider.transform.GetChild(9).gameObject.SetActive(false);
                slider.transform.GetChild(10).gameObject.SetActive(true);
                break;
            case (PlayerManager.PieceState.Quenn):
                slider.transform.GetChild(5).gameObject.SetActive(false);
                slider.transform.GetChild(6).gameObject.SetActive(true);
                slider.transform.GetChild(10).gameObject.SetActive(false);
                slider.transform.GetChild(11).gameObject.SetActive(true);
                break;
                
        }
        if(Input.GetMouseButton(0) && playerManager.playerState==PlayerManager.PlayerState.Stop){
            pawnrb.useGravity=true;
            homeui.SetActive(false);
        }
        if(playerManager.playerState==PlayerManager.PlayerState.Move){
            gameui.SetActive(true);
        } else if(playerManager.playerState==PlayerManager.PlayerState.Finish){
            gameui.SetActive(false);
        }
        switch (PlayerManager.collectedPiece)
        {
            case 1:
                setProgress(.16f);
                break;
            case 2:
                setProgress(.33f);
                break;
            case 3:
                setProgress(.5f);
                break;
            case 4:
                setProgress(.66f);
                break;
            case 5:
                setProgress(.84f);
                break;
            case 0:
                if(playerManager.pieceState==PlayerManager.PieceState.King){

                }else{
                setProgress(0f);
                } 
                break;
            
        }
    }
    void setProgress(float p){
        
        slider.value=Mathf.Lerp(slider.value,p,.2f);
    }


    

}
