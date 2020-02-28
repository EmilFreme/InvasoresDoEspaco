using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : Bullet { 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
