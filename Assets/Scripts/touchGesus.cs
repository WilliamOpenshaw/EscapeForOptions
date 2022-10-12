using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touchGesus : MonoBehaviour
{
    public GameObject gesusMessage;
    public GameObject enemySpawnMessage;
    public GameObject enemySpeedMessage;
    public GameObject platformSpawnMessage;
    public GameObject gravityOnMessage;
    public GameObject gravityOffMessage;
    public Transform gesusSpawn;

    public Target enemyMemeScript;

    public GameObject playerChar;

    public firePlayerGun gunChange;
    public Transform sanctuary;

    int gesusChoice;
    public EnemySpawn spawnScript;
    public Object[] EnemyArray;
    void Start()
    {
        gesusMessage.SetActive(false);
        enemySpeedMessage.SetActive(false);
        enemySpawnMessage.SetActive(false);
        platformSpawnMessage.SetActive(false);
        gravityOffMessage.SetActive(false);
        gravityOnMessage.SetActive(false);
        EnemyArray = new Object[100];
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                gesusChoice = Random.Range(1, 9);
                switch (gesusChoice)
                {
                    case 1:
                        StopAllCoroutines();
                        GameObject newEnemy1 = Instantiate(spawnScript.enemy1, gesusSpawn.transform.position, transform.rotation);
                        newEnemy1.GetComponent<Target>().PlaySoundSpeech();
                        StartCoroutine("MessageOnEnemySpawn");
                        break;

                    case 2:
                        StopAllCoroutines();
                        GameObject newEnemy2 = Instantiate(spawnScript.enemy2, gesusSpawn.transform.position, transform.rotation);
                        newEnemy2.GetComponent<Target>().PlaySoundSpeech();
                        StartCoroutine("MessageOnEnemySpawn");
                        break;

                    case 3:
                        StopAllCoroutines();
                        EnemyArray = GameObject.FindGameObjectsWithTag("Enemy");
                        for (int p = 0; p < GameObject.FindGameObjectsWithTag("Enemy").Length; p++)
                        {
                            GameObject.FindGameObjectsWithTag("Enemy")[p].GetComponent<EnemyFollow>().enemySpeed = Random.Range(0.03f, 0.1f);
                        }
                        StartCoroutine("MessageOnEnemySpeedChange");
                        break;

                    case 4:
                        StopAllCoroutines();
                        Instantiate(GameObject.FindGameObjectsWithTag("Platform")[Random.Range(1, GameObject.FindGameObjectsWithTag("Platform").Length)].gameObject, gesusSpawn.transform.position, Quaternion.identity);
                        StartCoroutine("MessageOnPlatformSpawned");
                        break;

                    case 5:
                        gunChange.RandomizeWeaponAndProjectile();
                        break;

                    case 6:
                        playerChar.transform.position = sanctuary.position;
                        break;

                    case 7:
                        playerChar.transform.position = sanctuary.position;
                        for (int m = 0; m < 30; m++)
                        {
                            GameObject memeInstance = Instantiate(enemyMemeScript.memeHolder, sanctuary.position, sanctuary.rotation) as GameObject;
                            memeInstance.tag = "Meme";
                            memeInstance.GetComponent<AssignFirstMeme>().ChooseFirstMemeFunction();
                        }
                        break;

                    case 8:
                        StopAllCoroutines();
                        for (int a = 0; a < GameObject.FindGameObjectsWithTag("Enemy").Length; a++)
                        {
                            GameObject.FindGameObjectsWithTag("Enemy")[a].GetComponent<Rigidbody>().useGravity = !GameObject.FindGameObjectsWithTag("Enemy")[a].GetComponent<Rigidbody>().useGravity;
                        }
                        for (int b = 0; b < GameObject.FindGameObjectsWithTag("Platform").Length; b++)
                        {
                            GameObject.FindGameObjectsWithTag("Platform")[b].GetComponent<Rigidbody>().useGravity = !GameObject.FindGameObjectsWithTag("Platform")[b].GetComponent<Rigidbody>().useGravity;
                        }
                        if (GameObject.FindGameObjectWithTag("Platform").GetComponent<Rigidbody>().useGravity == true)
                        {
                            StartCoroutine("MessageOnGravityChange", true);
                        }
                        else if (GameObject.FindGameObjectWithTag("Platform").GetComponent<Rigidbody>().useGravity == false)
                        {
                            StartCoroutine("MessageOnGravityChange", false);
                        }
                        break;

                }
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gesusMessage.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gesusMessage.SetActive(false);
        }
    }
    IEnumerator MessageOnEnemySpawn()
    {
        enemySpeedMessage.SetActive(false);
        platformSpawnMessage.SetActive(false);
        gravityOffMessage.SetActive(false);
        gravityOnMessage.SetActive(false);
        enemySpawnMessage.SetActive(false);
        enemySpawnMessage.SetActive(true);
        enemySpawnMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, 255);

        for (int i = 0; i < 51; i++)
        {
            yield return new WaitForSeconds(0.00001f);
            enemySpawnMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, (byte)(255 - i * 5));
        }
        enemySpawnMessage.SetActive(false);
    }
    IEnumerator MessageOnEnemySpeedChange()
    {

        enemySpawnMessage.SetActive(false);
        platformSpawnMessage.SetActive(false);
        gravityOffMessage.SetActive(false);
        gravityOnMessage.SetActive(false);
        enemySpeedMessage.SetActive(false);
        enemySpeedMessage.SetActive(true);
        enemySpeedMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, 255);

        for (int f = 0; f < 51; f++)
        {
            yield return new WaitForSeconds(0.00001f);
            enemySpeedMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, (byte)(255 - f * 5));
        }
        enemySpeedMessage.SetActive(false);
    }

    IEnumerator MessageOnPlatformSpawned()
    {
        enemySpeedMessage.SetActive(false);
        enemySpawnMessage.SetActive(false);
        gravityOffMessage.SetActive(false);
        gravityOnMessage.SetActive(false);
        platformSpawnMessage.SetActive(false);
        platformSpawnMessage.SetActive(true);
        platformSpawnMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, 255);

        for (int t = 0; t < 51; t++)
        {
            yield return new WaitForSeconds(0.00001f);
            platformSpawnMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, (byte)(255 - t * 5));
        }
        platformSpawnMessage.SetActive(false);
    }
    IEnumerator MessageOnGravityChange(bool gravityBool)
    {
        if (gravityBool == true)
        {
            enemySpeedMessage.SetActive(false);
            enemySpawnMessage.SetActive(false);
            platformSpawnMessage.SetActive(false);
            gravityOffMessage.SetActive(false);
            gravityOnMessage.SetActive(false);
            gravityOnMessage.SetActive(true);
            gravityOnMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, 255);

            for (int y = 0; y < 51; y++)
            {
                yield return new WaitForSeconds(0.00001f);
                gravityOnMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, (byte)(255 - y * 5));
            }
            gravityOnMessage.SetActive(false);
        }
        else if (gravityBool == false)
        {
            enemySpeedMessage.SetActive(false);
            enemySpawnMessage.SetActive(false);
            platformSpawnMessage.SetActive(false);
            gravityOnMessage.SetActive(false);
            gravityOffMessage.SetActive(false);
            gravityOffMessage.SetActive(true);
            gravityOffMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, 255);

            for (int u = 0; u < 51; u++)
            {
                yield return new WaitForSeconds(0.00001f);
                gravityOffMessage.gameObject.GetComponent<Text>().color = new Color32(185, 0, 255, (byte)(255 - u * 5));
            }
            gravityOffMessage.SetActive(false);
        }

    }
}
