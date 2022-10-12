using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    public Transform startingArea;
    public GameObject environment;
    public PortalKeyTrigger keyScript1;
    public PortalKeyTrigger keyScript2;
    public PortalKeyTrigger keyScript3;
    public PortalKeyTrigger keyScript4;
    public ChooseBGMusic musicBGScript;
    
    void OnAwake()
    {
        environment.SetActive(false);
    }
    void OnTriggerEnter (Collider other)
     {
         if (other.gameObject.tag == "Player")
        {
             musicBGScript.StartCoroutine("PlayNextClip", 0.0f);
             environment.SetActive(true);
            other.gameObject.transform.position = startingArea.position;           
            keyScript1.ResetKeys();
            keyScript2.ResetKeys();
            keyScript3.ResetKeys();
            keyScript4.ResetKeys();
            
        }
     }     
}
