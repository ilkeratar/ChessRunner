using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;
using UnityEngine.UI;
public class PieceController : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] List<GameObject> confetties;
    [SerializeField] CinemachineVirtualCamera cam1;
    [SerializeField] GameObject finishui;
    [SerializeField] Text finishtxt;
    [SerializeField] Text nextleveltxt;
    private float shakeTimer;
    private float startingIntensity;
    private float shakeTimerTotal;
    private Rigidbody rb;
    void Start() {
        playerManager=GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>();
        rb=GetComponent<Rigidbody>();
        if(playerManager.playerState==PlayerManager.PlayerState.Move){
            rb.useGravity=false;
            rb.constraints=RigidbodyConstraints.FreezeAll;
        }
          
    }
    private void Update() {

        if(shakeTimer>0){
            shakeTimer-=Time.deltaTime;
                CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = 
                cam1.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain=Mathf.Lerp(startingIntensity,0f,1-(shakeTimer/shakeTimerTotal));
            
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Obstacle")){
            StartCoroutine(HitObstacle());
        }
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("KingBlack"))
        {

            if(PlayerManager.totalPiece <4){
                Debug.Log("x1");
                other.rigidbody.AddForce(-transform.forward * 50);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,76.67f),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti"));
            }
            else if(PlayerManager.totalPiece >=4 && PlayerManager.totalPiece <8){
                Debug.Log("x2");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,78.2f),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti2"));
            }
            else if(PlayerManager.totalPiece >=8 && PlayerManager.totalPiece <10){
                Debug.Log("x3");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,79.8f),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti3"));
            }
            else if(PlayerManager.totalPiece >=10 && PlayerManager.totalPiece <12){
                Debug.Log("x4");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,81.1f),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti4"));
            }
            else if(PlayerManager.totalPiece >=12 && PlayerManager.totalPiece <16){
                Debug.Log("x5");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,83),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti5"));
            }
            else if(PlayerManager.totalPiece >=16 && PlayerManager.totalPiece <22){
                Debug.Log("x6");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,84.6f),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti6"));
            }
            else if(PlayerManager.totalPiece >=22 && PlayerManager.totalPiece <24){
                Debug.Log("x7");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,86.2f),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti7"));
            }
            else if(PlayerManager.totalPiece >=24 && PlayerManager.totalPiece <28){
                Debug.Log("x8");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,87.5f),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti8"));
            }
            else if(PlayerManager.totalPiece >=28 && PlayerManager.totalPiece <34){
                Debug.Log("x9");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,89.2f),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti9"));
            }
            else if(PlayerManager.totalPiece >33){
                Debug.Log("x10");
                other.rigidbody.AddForce(-transform.forward * 100);
                other.rigidbody.useGravity=true;
                DOTween.Sequence().Append(other.transform.DOMove(new Vector3(0,2.05f,101),0.8f).SetEase(Ease.Unset));
                StartCoroutine(Confetti("Confetti10"));
            }
        }
    }

    

    IEnumerator HitObstacle()
    {
        Movement.movementSpeed=-3f;
        ShakeCamera(2f,.2f);
        yield return new WaitForSeconds(0.5f);
        Movement.movementSpeed=4f;
    }
    public void ShakeCamera(float intensity,float time){
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin=
        cam1.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain=intensity;
        startingIntensity=intensity;
        shakeTimerTotal=time;
        shakeTimer=time;
    }
    IEnumerator Confetti(string name){
        yield return new WaitForSeconds(1.8f);
        foreach (GameObject item in confetties)
        {
            if(item.name == name){
                item.gameObject.SetActive(true);
            }
        }
        yield return new WaitForSeconds(.1f);
        finishui.SetActive(true);
            finishtxt.text="Level "+PlayerPrefs.GetInt("Level",1)+" Completed!";
            finishtxt.DOFade(1,2).SetEase(Ease.OutBack);
        nextleveltxt.gameObject.SetActive(true);
        playerManager.levelState=PlayerManager.LevelState.Finished;
    }
}
