using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SCR_GameManager : MonoBehaviour
{
    public int classToPass;

    public IList<GameObject> cadavres = new List<GameObject>();
    public IList<GameObject> cartes = new List<GameObject>();

    public Transform[] cardslots;
    public SCR_CardScript cardscript;
    public SCR_Cadavre cadavreScript;
    public SCR_CardProperties cardppScript;
    public bool[] cardslotsAvailable;

    public GameObject carte;
    public GameObject carteInst;

    public TextMeshPro CardName;
    public TextMeshPro CardDesc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Arise()
    {
        foreach (GameObject obj in cadavres)
        {
            if (cartes.Count <= 6)
            {
                cadavreScript = obj.GetComponent<SCR_Cadavre>();
                classToPass = cadavreScript.cardClass;

                carteInst = Instantiate(carte, obj.transform.position, Quaternion.identity);
                cartes.Add(carteInst);
            }
            
            Destroy(obj);
        }
        PlaceCards(); 

        cadavres.Clear();
    }

    public void PlaceCards()
    {
        foreach (GameObject carte in cartes)
        {
            cardscript = carte.GetComponent<SCR_CardScript>();

            if (cardscript.slot == null)
            { 
                for (int i = 0; i < cardslotsAvailable.Length; i++)
                {
                    if (cardslotsAvailable[i] == true)
                    {
                        carte.transform.position = cardslots[i].position;
                        
                        cardscript.slot = cardslots[i];
                        cardslotsAvailable[i] = false;
                        break;
                    }
                }
            }
            else
            {
                carte.transform.position = cardscript.slot.position;
            }
        }
    }
}
