using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakTheGame : MonoBehaviour
{
    public GameObject breakGameMessage;
    public Target enemyMemeScript;
    public EnemySpawn spawnScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                for (int m = 0; m < 1000; m++)
                {
                    GameObject memeInstance = Instantiate(enemyMemeScript.memeHolder, transform.position, transform.rotation) as GameObject;
                    memeInstance.tag = "Meme";
                    memeInstance.GetComponent<AssignFirstMeme>().ChooseFirstMemeFunction();
                }
                for (int k = 0; k < 1000; k++)
                {
                    GameObject newEnemy1 = Instantiate(spawnScript.enemy1, transform.position, transform.rotation);
                    newEnemy1.GetComponent<Target>().PlaySoundSpeech();
                    GameObject newEnemy2 = Instantiate(spawnScript.enemy2, transform.position, transform.rotation);
                    newEnemy1.GetComponent<Target>().PlaySoundSpeech();  
                    Instantiate(GameObject.FindGameObjectsWithTag("Platform")[Random.Range(1, GameObject.FindGameObjectsWithTag("Platform").Length)].gameObject, transform.position, Quaternion.identity);                  
                }
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            breakGameMessage.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            breakGameMessage.SetActive(false);
        }
    }
}
