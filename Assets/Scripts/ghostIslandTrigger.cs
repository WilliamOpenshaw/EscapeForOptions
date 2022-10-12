using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ghostIslandTrigger : MonoBehaviour
{
    public GameObject ghostIslandMessage;

    void Start()
    {
        ghostIslandMessage.SetActive(false);
    }
    void OnTriggerEnter (Collider other)
     {
         if (other.gameObject.tag == "Player")
        { 
            StartCoroutine(GhostMessageOnRespawn());
        }
     }   

     IEnumerator GhostMessageOnRespawn()
    {
        ghostIslandMessage.SetActive(true);
        ghostIslandMessage.gameObject.GetComponent<Text>().color = new Color32(0, 0, 0, 255);
        
        for (int i = 0; i < 85; i++)
        {            
            yield return new WaitForSeconds(0.00001f);
            ghostIslandMessage.gameObject.GetComponent<Text>().color = new Color32((byte)Random.Range(1, 255), (byte)Random.Range(1, 255), (byte)Random.Range(1, 255), (byte)(255 - i));
        }
        ghostIslandMessage.SetActive(false);
    }
}
