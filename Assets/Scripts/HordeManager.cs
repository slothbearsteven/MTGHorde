using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HordeManager : MonoBehaviour
{
    public static int hordeDeckCurrentAmount;
    public GameObject[] hordeCards;
    private int hordeDeckTotal = 100;


    // Start is called before the first frame update
    void Start()
    {
        hordeDeckCurrentAmount = hordeDeckTotal;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CardSelection()
    {
        int cardToPlay = Random.Range(1, 26);

        if (cardToPlay == 26)
        {
            Tokens.numberOfTokens++;
            CardSelection();
        }
        else
        {
            hordeCards[cardToPlay].SetActive(true);
        }
    }
}
