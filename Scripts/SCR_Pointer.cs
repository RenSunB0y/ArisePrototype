using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Pointer : MonoBehaviour
{
    public Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 1;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = mousePos;
    }
}
