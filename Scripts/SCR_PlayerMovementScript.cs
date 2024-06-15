using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerMovementScript : MonoBehaviour
{
    public GameObject spriteHaut;
    public GameObject spriteMilieu;
    public GameObject spriteBas;

    public int spriteActif = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setActiveSprite();
        SetRightSprite();
    }

    void setActiveSprite()
    {
        if (Input.GetKeyDown(KeyCode.W) && spriteActif != 0)
        {
            spriteActif -= 1;
        }

        if (Input.GetKeyDown(KeyCode.S) && spriteActif != 2)
        {
            spriteActif += 1;
        }
    }

    void SetRightSprite()
    {
        switch (spriteActif)
        {
            case 0:
                spriteHaut.SetActive(true);
                spriteMilieu.SetActive(false);
                spriteBas.SetActive(false);
                break;

            case 1:
                spriteHaut.SetActive(false);
                spriteMilieu.SetActive(true);
                spriteBas.SetActive(false);
                break;

            case 2:
                spriteHaut.SetActive(false);
                spriteMilieu.SetActive(false);
                spriteBas.SetActive(true);
                break;
        }
    }
}
