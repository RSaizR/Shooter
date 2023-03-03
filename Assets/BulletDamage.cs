using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ship" || coll.gameObject.tag == "EnemyBullet")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}
