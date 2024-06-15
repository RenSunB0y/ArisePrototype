using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerFire : MonoBehaviour
{
    public float firetimer;
    public float fireRate;

    public SCR_PlayerMovementScript playerMoveScript;

    public GameObject bullet;

    public Transform spriteActuelTrs;

    private void Start()
    {
        playerMoveScript = this.gameObject.GetComponent<SCR_PlayerMovementScript>();
    }
    private void FixedUpdate()
    {
        Fire();
    }

    void Fire()
    {
        if (firetimer >= fireRate)
        {
            firetimer = 0;
            DetermineSpritePos();
            Instantiate(bullet, spriteActuelTrs.position, Quaternion.identity);
        }
        else
        { firetimer += 1; }
    }

    void DetermineSpritePos()
    {
        switch(playerMoveScript.spriteActif)
        {
            case 0:
                spriteActuelTrs = playerMoveScript.spriteHaut.transform;
                break;

            case 1:
                spriteActuelTrs = playerMoveScript.spriteMilieu.transform;
                break;

            case 2:
                spriteActuelTrs = playerMoveScript.spriteBas.transform;
                break;
        }
    }
}
