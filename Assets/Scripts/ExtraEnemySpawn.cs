using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraEnemySpawn : MonoBehaviour
{
    public GameObject spawnMessage;

    public Transform monsterSpawn;

    int spawnChoice;
    public EnemySpawn spawnScript;
     void Start()
   {
       spawnMessage.SetActive(false);
   }
    void OnTriggerStay (Collider other)
     {
         if (other.gameObject.tag == "Player")        
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                spawnChoice = Random.Range(1, 3);
                switch (spawnChoice)
                {
                    case 1:
                        GameObject newEnemy1 = Instantiate(spawnScript.enemy1, monsterSpawn.transform.position, transform.rotation);
                        newEnemy1.GetComponent<Target>().PlaySoundSpeech(); 
                        break;

                    case 2:
                        GameObject newEnemy2 = Instantiate(spawnScript.enemy2, monsterSpawn.transform.position, transform.rotation);
                        newEnemy2.GetComponent<Target>().PlaySoundSpeech();
                        break;
                }
            }                     
        }
     }
     void OnTriggerEnter (Collider other)
     {
         if (other.gameObject.tag == "Player")
        {         
            spawnMessage.SetActive(true);                        
        }
     }   
     void OnTriggerExit (Collider other)
     {
         if (other.gameObject.tag == "Player")
        {
            spawnMessage.SetActive(false);
        }
     }        
}
