using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tokens : MonoBehaviour
{
    public GameObject tokenCard;
    public static int numberOfTokens = 0;

    public Text countText;
    private int tokensPower = 2;

    private int tokensToughness = 2;
    public Text powerToughnessText;

    public static int tokenDamageTotal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tokenDamageTotal = numberOfTokens * tokensPower;

        if (numberOfTokens == 0) { tokenCard.SetActive(false); }
        else
        {
            tokenCard.SetActive(true);
        }
    }
    void AddTokens()
    {
        numberOfTokens++;
    }

    void RemoveTokens()
    {
        numberOfTokens--;
    }

    void SetText()
    {
        countText.text = $"x {numberOfTokens}";

        powerToughnessText.text = $"{tokensPower}/{tokensToughness}";
    }



}
