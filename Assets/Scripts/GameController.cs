using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;
    public UIManager m_ui;

    float m_spawnTime;
    int m_score;
    bool is_GameOver;

    public bool GameOver
    {
        get{ return is_GameOver; }
        set { is_GameOver = value; }
    }

    public int Score
    {
        get { return m_score; }
        set { m_score = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.setTextScore($"Score: {m_score}");
    }

    // Update is called once per frame
    void Update()
    {
        if (is_GameOver)
        {
            m_spawnTime = 0;
            m_ui.ShowGameOverPanel(is_GameOver);
            return;
        }
        m_spawnTime -= Time.deltaTime;
        if (m_spawnTime <= 0 )
        {
            HandleSpawnTime();

            m_spawnTime = spawnTime;
        } 
    }

    public void HandleSpawnTime() {
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);

        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity); // khoi tao qua bong, vi tri qua bong , va khong cho qua bong xoay
        }
    }

    public void IncreaseStore()
    {
        m_score++;
        m_ui.setTextScore($"Score: {m_score}");
    }

    public void Replay()
    {
        m_spawnTime = m_score = 0;
        is_GameOver = false;
        m_ui.setTextScore("Score: 0");
        m_ui.ShowGameOverPanel(false);
    }

}
