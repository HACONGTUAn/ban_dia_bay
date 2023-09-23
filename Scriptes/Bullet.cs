using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float sp;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        BulletKill();
        if(transform.position.y > 7)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("UFO")) {
            Destroy(gameObject);
        }

       
    }
    private void BulletKill()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + sp);
    }
}
