using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AssignFirstMeme : MonoBehaviour
{
    public GameObject memePickUpMessage;
    public int currentMemeNum;
    public Texture loadedMemeTexture;
    public memeMarketController memeController;

    public GameObject noMemeMessage;

    public void Start()
    {
        if(gameObject.CompareTag("TestMeme"))
        {
            StartCoroutine("ChooseFirstMemeDelayed", 1.0f);
        }        
        memePickUpMessage.SetActive(false);
    }

    public void ChooseFirstMemeFunction()
    {
        currentMemeNum = Random.Range(0, memeController.memePicFilesArray.Length);
        loadedMemeTexture = (Texture)memeController.memePicFilesArray[currentMemeNum];
        gameObject.GetComponent<Renderer>().material.SetTexture("_MainTex", loadedMemeTexture);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.CompareTag("Player"))
            {
                memeController.memeShares[currentMemeNum] = memeController.memeShares[currentMemeNum] + 1;

                noMemeMessage.SetActive(false);

                memeController.memePickedUp[currentMemeNum] = true;

                memePickUpMessage.SetActive(false);

                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            memePickUpMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            memePickUpMessage.SetActive(false);
        }
    }
    IEnumerator ChooseFirstMemeDelayed(float time)
    {
        yield return new WaitForSeconds(time);
        ChooseFirstMemeFunction();

    }
}
