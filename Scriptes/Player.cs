using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float toc_do;
    public GameObject bullet;
    int m_timeKill;
    GameManager m_gc;
    // Start is called before the first frame update
    
    void Start()
    {
        m_timeKill = 2;
        m_gc = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        m_timeKill--;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x >= -8)
            {
                transform.position = new Vector2(transform.position.x - toc_do, transform.position.y);
            }
            else
            {
                return;
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x <= 8)
            {
                transform.position = new Vector2(transform.position.x + toc_do, transform.position.y);
            }
            else
            {
                return;
            }
        }
        if(Input.GetKey(KeyCode.Space) && m_timeKill <= 0) {
            Vector2 spont = new Vector2(transform.position.x, transform.position.y);
            Instantiate(bullet,spont, Quaternion.identity);
            m_timeKill = 2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("UFO"))
        {
            Debug.Log("ban da thua");
            m_gc.setGameOver(true);
        }
    }
}
