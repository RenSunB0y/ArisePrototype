using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class SCR_BulletBehaviour : MonoBehaviour
{
    public float bulletSpeed;
    public int damage;
    public SCR_enemyProperties enemyActuel;



    private void Update()
    {
        Move();

        if (transform.position.x >= 18)
        {
            Destroy();
        }
    }

    void Move()
    {
        transform.position += (Vector3.right * bulletSpeed) * Time.deltaTime;
    }

    void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            enemyActuel = collision.gameObject.GetComponent<SCR_enemyProperties>();
            enemyActuel.hp -= damage;
            Destroy();
        }
    }
}
