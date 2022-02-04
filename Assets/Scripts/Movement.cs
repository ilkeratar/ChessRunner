using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Movement : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    public static float movementSpeed;
    [SerializeField] float controlSpeed;
    [SerializeField] bool isTouching;
    float touchPosX;
    Vector3 direction;
    Transform king;
    float NewX = 0;

    void Start() {
        king=GameObject.FindGameObjectWithTag("KingBlack").transform;
        movementSpeed=4f;
    }

    void Update() {
        GetInput();    
    }

    private void FixedUpdate() {
        if(playerManager.playerState==PlayerManager.PlayerState.Move){
            transform.position+=Vector3.forward*movementSpeed*Time.fixedDeltaTime;
            if(isTouching){
            touchPosX+=Input.GetAxis("Mouse X")* controlSpeed*Time.fixedDeltaTime;
            NewX = Mathf.Clamp(touchPosX ,-2.43f,2.43f);
            transform.position=new Vector3(NewX,transform.position.y,transform.position.z);
            }
        }
        if(playerManager.playerState==PlayerManager.PlayerState.Finish){
            DOTween.Sequence().Append(transform.DOMove(new Vector3(0,2.05f,73.4f),2).SetEase(Ease.Unset));
        }

        
    }

    void GetInput(){
        if(Input.GetMouseButton(0)){
            isTouching=true;
        }else{
            isTouching=false;
        }
    }
}
