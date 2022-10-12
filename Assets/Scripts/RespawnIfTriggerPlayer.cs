using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnIfTriggerPlayer : MonoBehaviour
{
   //public Transform respawnPoint;
    public GameObject respawnText;    
    public int spawnChoice;

    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        } 
        //else if (other.gameObject.tag == "Platform")
        //{           
            
        //} 
        else  if (other.gameObject.tag == "Player")
        {            
            spawnChoice = UnityEngine.Random.Range(1, GameObject.FindGameObjectsWithTag("EnemySpawn").Length + 1);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.transform.position = GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnChoice].transform.position;
            StartCoroutine(MessageOnRespawn());
        } 
        else 
        {
            spawnChoice = UnityEngine.Random.Range(1,  GameObject.FindGameObjectsWithTag("EnemySpawn").Length);
            if(other.gameObject.GetComponent<Rigidbody>() != null)
            {
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }            
            other.gameObject.transform.position = GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnChoice].transform.position;
        }
    }
    IEnumerator MessageOnRespawn()
    {
        respawnText.SetActive(true);
        respawnText.gameObject.GetComponent<Text>().color = new Color32(255, 0, 0, 255);
        
        for (int i = 0; i < 85; i++)
        {            
            yield return new WaitForSeconds(0.00001f);
            respawnText.gameObject.GetComponent<Text>().color = new Color32(255, 0, 0, (byte)(255 - i*3));
        }
        respawnText.SetActive(false);
    }
    /*
    else  if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.transform.position = respawnPoint.transform.position;
            StartCoroutine(MessageOnRespawn());
        }
     */
}
