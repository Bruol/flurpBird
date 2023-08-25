using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public TMPro.TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    public void incScore(int amount){

        score += amount;
        scoreText.text = score.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverPanel.SetActive(true);
    }

}
        