using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_enemyProperties : MonoBehaviour
{
    public int hp;
    public int damage;
    public int randClass;
    public float range;
    public string className;
    public string classDesc;

    public GameObject cadavre;
    public GameObject cadavreInst;

    public SCR_GameManager gameManagerScript;
    public SCR_Cadavre cadavreScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.FindGameObjectWithTag("manager").GetComponent<SCR_GameManager>();

        randClass = Random.Range(0, 2);

        SetClass();

        name = className;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Death();
        }
    }

    private void SetClass()
    {
        switch (randClass)
        {
            case 0:
                hp = 2;
                damage = 1;
                range = 2.5f;
                className = "melee";
                classDesc = "hp = 2\r\n                damage = 1";
                break;

            case 1:
                hp = 1;
                damage = 2;
                range = 6;
                className = "range";
                break;
        }
    }

    public void Death()
    {
        PopCadavre();
        Destroy(gameObject);
    }

    public void PopCadavre()
    {
        cadavreInst = Instantiate(cadavre, transform.position, Quaternion.identity);
        cadavreScript = cadavreInst.GetComponent<SCR_Cadavre>();
        cadavreScript.cardClass = randClass;
        gameManagerScript.cadavres.Add(cadavreInst);
    }
}
