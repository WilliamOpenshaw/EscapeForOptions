using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyOnOff : MonoBehaviour
{
    public GameObject northSkyHemisphere;
    public GameObject southSkyHemisphere;
   void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Sun"))
        {
            northSkyHemisphere.SetActive(!northSkyHemisphere.activeSelf);
            southSkyHemisphere.SetActive(!southSkyHemisphere.activeSelf);
        }       
    }
}
