using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{

    public string cardType;
    public string manaCost;

    public int power;
    public int toughness;

    public GameObject cardDetails;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cardType == "creature")
        {

        }

        if (cardType == "artifact" || cardType == "enchantment")
        {

        }


    }

    void RemoveCard()
    {
        //using this as a way to resolve
        HordeManager.graveyardNumber++;
        gameObject.SetActive(false);
    }

}
