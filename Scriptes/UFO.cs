using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    // Start is called before the first frame update
    public float hp;
    public float speed;

    Rigidbody2D rb;
    GameManager m_gc;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        m_gc = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector2.up * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
             hp--;
            if (hp <= 0)
            {
                Destroy(gameObject);
                m_gc.ScoreIncrement();
            }
        }
        if (collision.CompareTag("Remove"))
        {
            Destroy(gameObject);
            m_gc.ScoreFaile();
        }
    }
}
