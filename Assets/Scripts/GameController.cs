using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime; //time tao bong tiep theo sau khi bong kia mat
    float m_spawnTime; // bien dung de giam thoi gian

    bool m_isGameOver;// dung kiem tra gameover
    int score;

    UIManager m_ui;
    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>(); // tim tat ca UIManager
        m_ui.SetScoreText("Score: 0"); // set diem ban dau la 0
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;// thoi gian giam dan
        if (m_isGameOver)
        {
            m_spawnTime = 0;
            m_ui.ShowGameOverPanel(true);
            return;
        }
        if (m_spawnTime <= 0)
        {
            SpawnBall();
            m_spawnTime = spawnTime; // gan lai thoi gian ban dau

        }
        
    }

    public void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-15, 15), 10); // tao vi tri ngau nhien de xuat hien bong
        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }

    }

    public void Replay()
    {
        score = 0;
        m_isGameOver = false;
        m_ui.SetScoreText("Score: " + score);
        m_ui.ShowGameOverPanel(false);
    }
    public void SetScore (int value)
    {
        score = value;
    }
    public int GetScore ()
    {
        return score;
    }
    //Tang gia tri diem
    public void IncrementScore ()
    {
        score++;
        m_ui.SetScoreText("Score: " + score);
    }
    public void SetIsGameOver(bool state)
    {
        m_isGameOver = state;
    }
    public bool IsGameOver()
    {
        return m_isGameOver;
    }
}
