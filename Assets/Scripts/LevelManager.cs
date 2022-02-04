using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject currentLvl;
    [SerializeField] PlayerManager playerManager;
    [SerializeField] GameObject nextLvl;
    private void Awake() {
        PlayerPrefs.SetInt("Level",PlayerPrefs.GetInt("Level")+1);
    }

    private void Update() {
        if(playerManager.levelState==PlayerManager.LevelState.Finished && Input.GetMouseButtonDown(0))
        {
            NextLevel();
        }
        
    }
    public void NextLevel(){
        Destroy(currentLvl);
        Instantiate(nextLvl);
    }
}
