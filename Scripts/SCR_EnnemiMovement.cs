using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_EnnemiMovement : MonoBehaviour
{
    public float enemySpeed;
    public float distanceToPlayer;

    public GameObject player;

    public SCR_enemyProperties ppScript;

    // Start is called before the first frame update
    void Start()
    {
        ppScript = gameObject.GetComponent<SCR_enemyProperties>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x - 1.667f, transform.position.y), Vector2.left, Mathf.Infinity);

        if (hit.collider != null )
        {
            if (hit.collider.tag == "Player" || hit.collider.tag == "shadow")
            { 
                distanceToPlayer = Mathf.Abs(hit.collider.gameObject.transform.position.x - transform.position.x); 
            }
            else
            {
                distanceToPlayer = Mathf.Abs(player.transform.position.x - transform.position.x);
            }
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Move();
    }

    void Move()
    {
        if (distanceToPlayer > ppScript.range)
        { transform.position += (Vector3.left * enemySpeed) * Time.deltaTime; }
        else
        {
            //attaque
        }
    }

    void Attack()
    {

    }
}
