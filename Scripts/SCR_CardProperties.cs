using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SCR_CardProperties : MonoBehaviour
{
    public int hp;
    public int damage;
    public int passedClass;

    public float range;

    public string className;
    public string classDesc;

    public SCR_GameManager manager;

    public TextMeshPro[] texts;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("manager").GetComponent<SCR_GameManager>();
        texts = gameObject.GetComponentsInChildren<TextMeshPro>();
        passedClass = manager.classToPass;
        SetClass();
        SetUpCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetClass()
    {
        switch (passedClass)
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
                classDesc = "hp = 1\r\n                damage = 2";
                break;
        }
    }

    private void SetUpCard()
    {
        texts[0].text = className;
        texts[1].text = classDesc;
    }
}
