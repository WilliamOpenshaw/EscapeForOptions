using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class blueCollide : MonoBehaviour
{
    bool buttonPressed;

    bool coroutineRunning;

    public GameObject loadingMessage;

    public GameObject loadingNumText;
    public GameObject donationInfo;

    public float loadingValue;

    public GameObject escMenu;

    public float savedTime2;

    public GameObject gameVolume;

    public void Start()
    {
        donationInfo.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        buttonPressed = false;
        coroutineRunning = false;
        loadingMessage.SetActive(false);

        escMenu.SetActive(false);
        savedTime2 = 0.0f;
        AudioListener.volume = 0.5f;
        gameVolume.GetComponent<Text>().text =
            (AudioListener.volume * 100f).ToString("00");
    }

    void Update()
    {
        if (loadingMessage.activeSelf == true && buttonPressed == true && coroutineRunning == false)
        {
            StartCoroutine("LoadYourAsyncScene");
        }
        if (Input.GetKeyDown(KeyCode.B) && coroutineRunning == false)
        {
            loadingMessage.SetActive(true);
            loadingNumText.SetActive(true);
            buttonPressed = true;            
        }
        if (escMenu.activeSelf == true && Input.GetKeyDown(KeyCode.Escape))
        {
            escMenu.SetActive(false);
        }
        else if (escMenu.activeSelf == false && Input.GetKeyDown(KeyCode.Escape)
        )
        {
            escMenu.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Slash) || Input.GetKeyDown(KeyCode.Question))
        {

            donationInfo.SetActive(!donationInfo.activeSelf);
            if (donationInfo.activeSelf == true)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else if (donationInfo.activeSelf == false)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }

        }

        if(Input.GetKey(KeyCode.Keypad9) || Input.GetKey(KeyCode.Alpha9))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.Keypad1) || Input.GetKey(KeyCode.Alpha1))
        {
            if (Time.time > savedTime2 + 0.01f && AudioListener.volume > 0.01f)
            {
                AudioListener.volume = AudioListener.volume - 0.01f;
                gameVolume.GetComponent<Text>().text =
                    (AudioListener.volume * 100f).ToString("00");
                savedTime2 = Time.time;
            }
        }
        if (Input.GetKey(KeyCode.Keypad2) || Input.GetKey(KeyCode.Alpha2))
        {
            if (Time.time > savedTime2 + 0.01f && AudioListener.volume < 0.99f)
            {
                AudioListener.volume = AudioListener.volume + 0.01f;
                gameVolume.GetComponent<Text>().text =
                    (AudioListener.volume * 100f).ToString("00");
                savedTime2 = Time.time;
            }
        }
        /*
        if (Time.time > savedTime2 + 5.0f && coroutineRunning == false)
        {
            savedTime2 = Time.time;
            coroutineRunning = true;
            StartCoroutine("LoadYourAsyncScene");
        }
        */
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        //&& asyncLoadBlue.isDone
        {
            //enable press b for blue pill
            enableB.bAppear = true;
        }
    }

    /*
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (
                Input.GetKeyDown(KeyCode.B) &&
                //&& asyncLoadBlue.isDone
                coroutineRunning == false
            )
            {
                loadingMessage.SetActive(true);
                loadingNumText.SetActive(true);
                buttonPressed = true;
                StartCoroutine("LoadYourAsyncScene");
                //SceneManager.LoadSceneAsync("memeallprefabs");
            }
        }
    }
*/
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //disable press b for blue pill
            enableB.bAppear = false;
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        //savedTime2 = Time.time;
        coroutineRunning = true;

        //SceneManager.UnloadSceneAsync("PillChoice");
        AsyncOperation asyncLoad =
            SceneManager.LoadSceneAsync("memeallprefabs");
        asyncLoad.allowSceneActivation = true;

        while (!asyncLoad.isDone || buttonPressed == false)
        {
            //loadingValue = asyncLoad.progress;
            //if (Time.time > savedTime2 + 1.0f)
            //{
            loadingNumText.GetComponent<Text>().text =
                (asyncLoad.progress * 100.0f).ToString() + "%";

            /*
                if (asyncLoad.progress >= 0.9f && buttonPressed == true)
                {
                    asyncLoad.allowSceneActivation = true;
                }
            */
            //savedTime2 = Time.time;
            // }
            yield return null;
        }
       
    }
}
