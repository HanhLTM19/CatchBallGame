using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;
    
    //set text cua diem
    public void SetScoreText (string txt)
    {
        if (scoreText)
        {
            scoreText.text = txt;
        }
    }
    // an va hien thong bao gameover
    public void ShowGameOverPanel(bool isShow)
    {
        if (gameOverPanel)
        {
            gameOverPanel.SetActive(isShow);
        }
    }
}
