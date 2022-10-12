using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunNoonMarketUpdateCaller : MonoBehaviour
{
    public memeMarketController memeControllerScript;
    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Sun"))
        {
            memeControllerScript.MarketUpdate();    
        }
        
    }
    
}
