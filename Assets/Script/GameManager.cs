using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] Ball ball;

    private void Start() {
        gameOverPanel.SetActive(false);
    }

    private void Update() {
        if(ball.Entered && gameOverPanel.activeInHierarchy == false){
            gameOverPanel.SetActive(true);
        }
    }

    public void BackToMainMenu(){
        SceneLoader.Load("MainMenu");
    }
    public void Replay(){
        SceneLoader.ReloadLevel();
    }
    public void PlayNext(){
        SceneLoader.LoadNextLevel();
    }
}
