using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gameController;
    private void Start()
    {
        m_gameController = FindObjectOfType<GameController>(m_gameController); // tim kiem tat ca cac type GameControl
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        if (collision.gameObject.CompareTag("Player"))
        {
            m_gameController.IncrementScore();// tang diem
            Destroy(gameObject);// xoa doi tuong
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            m_gameController.SetIsGameOver(true);
            Destroy(gameObject);
        }
    }
}
