using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class redCollide : MonoBehaviour
{
    //AsyncOperation asyncLoadRed;
    bool buttonPressed;

    public GameObject loadingNumText;

    public GameObject loadingMessage;

    bool coroutineRunning;

    // Start is called before the first frame update
    void Start()
    {
        loadingMessage.SetActive(false);

        //asyncLoadRed = SceneManager.LoadSceneAsync("redpillarmyscene");
        buttonPressed = false;
        coroutineRunning = false;
    }

    void Update()
    {
        if (loadingMessage.activeSelf == true && buttonPressed == true)
        {
            StartCoroutine("LoadYourAsyncScene");
        }
        if (Input.GetKeyDown(KeyCode.R) && coroutineRunning == false)
        {
            loadingMessage.SetActive(true);
            loadingNumText.SetActive(true);
            buttonPressed = true;            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player" || other.tag == "MainCamera")
        if (other.tag == "Player")
        //&& asyncLoadRed.isDone
        {
            //enable press r for blue pill
            enableR.rAppear = true;
        }
    }
    /*
    void OnTriggerStay(Collider other)
    {
        //if (other.tag == "Player" || other.tag == "MainCamera")
        if (other.tag == "Player")
        {
            if (
                Input.GetKeyDown(KeyCode.R) &&
                //&& asyncLoadRed.isDone

                coroutineRunning == false
            )
            {
                loadingMessage.SetActive(true);
                loadingNumText.SetActive(true);
                buttonPressed = true;
                StartCoroutine("LoadYourAsyncScene");
            }
        }
    }
    */
    void OnTriggerExit(Collider other)
    {
        //if (other.tag == "Player" || other.tag == "MainCamera")
        if (other.tag == "Player")
        {
            //disable press r for blue pill
            enableR.rAppear = false;
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        //savedTime2 = Time.time;
        coroutineRunning = true;

        //SceneManager.UnloadSceneAsync("PillChoice");
        AsyncOperation asyncLoad =
            SceneManager.LoadSceneAsync("redpillarmyscene");
        asyncLoad.allowSceneActivation = true;

        while (!asyncLoad.isDone || buttonPressed == false)
        {
            //loadingValue = asyncLoad.progress;
            loadingNumText.GetComponent<Text>().text =
                (asyncLoad.progress * 100.0f).ToString() + "%";
            /*
            if (asyncLoad.progress >= 0.9f && buttonPressed == true)
            {
                asyncLoad.allowSceneActivation = true;
            }
            */
            yield return null;
        }
    }
}
