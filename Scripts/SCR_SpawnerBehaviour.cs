using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_SpawnerBehaviour : MonoBehaviour
{
    public float SpawnTimer;
    public float SpawnRate = 90;

    public GameObject Ennemi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    public void Spawn()
    {
        if (SpawnTimer >= SpawnRate)
        {
            SpawnTimer = 0;
            Instantiate(Ennemi, transform.position, Quaternion.identity);
        }
        else
        { SpawnTimer += Time.deltaTime; }
    }
}
