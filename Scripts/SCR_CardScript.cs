using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_CardScript : MonoBehaviour
{
    public bool inHand = false;
    public GameObject pointer;
    public Transform slot;

    // Start is called before the first frame update
    void Start()
    {
        pointer = GameObject.FindGameObjectWithTag("pointer");
    }

    // Update is called once per frame
    void Update()
    {
        if (inHand)
        { FollowHand(); }
    }

    private void OnMouseDown()
    {
        inHand = true;
    }

    private void OnMouseUp()
    {
        inHand = false;
        transform.position = slot.position;
    }

    private void FollowHand()
    {
        transform.position = pointer.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ShadowSlot")
        {
            Debug.Log("oui");
        }
    }
}
