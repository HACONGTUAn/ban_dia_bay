using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ufo;
    public float spawnTime;
    float m_spawnTime;
 
    int m_score;
    bool m_gameover;
    UIMangager m_ui;
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIMangager>();
        m_ui.SetScoreText("Score : " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_gameover)
        {
            m_spawnTime = 0;
            m_ui.ShowGameoverPanel(true);
                return;
        }
        m_spawnTime -= Time.deltaTime;
        if(m_spawnTime <=  0)
        {
            SpawnUFO();
            m_spawnTime = spawnTime;
        }
        
    }
    
    public void SpawnUFO()
    {
        float x = Random.Range(-8f, 8f);
     
        Vector2 spawnPos = new Vector2(x,6);

        if (ufo)
        {
            Instantiate(ufo, spawnPos, Quaternion.identity);
        }

    }
    // diem cua nguoi choi
    public void setScore(int value)
    {
        m_score = value;
    }
    public int getScore()
    {
        return m_score;
    }
    public void ScoreIncrement()
    {
        m_score++;
        m_ui.SetScoreText("Score : " + m_score);
    }
    public void ScoreFaile()
    {
        m_score--;
        m_ui.SetScoreText("Score : " + m_score);
    }
    // trang thai game
    public void setGameOver(bool stat)
    {
        m_gameover = stat;
    }
    public bool getGameOver()
    {
        return m_gameover;
    }

    public void Replay()
    {
        SceneManager.LoadScene("hello");
    }

    public void Exit()
    {
       
    }
}
