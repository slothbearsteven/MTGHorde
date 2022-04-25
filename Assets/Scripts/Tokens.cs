using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokens : MonoBehaviour
{
    public GameObject tokenCard; 
    public static int numberOfTokens = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(numberOfTokens==0){tokenCard.SetActive(false);}
        else
        {
            tokenCard.SetActive(true);
        }
    }
}
