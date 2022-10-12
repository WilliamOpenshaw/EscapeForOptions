using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startFade : MonoBehaviour
{
    public GameObject endText;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        gameObject.gameObject.GetComponent<Text>().color = new Color32(255, 255, 255, 0);
        endText.gameObject.GetComponent<Text>().color = new Color32(255, 255, 255, 0);
        StartCoroutine("StartFade");
    }
    // Update is called once per frame    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("PillChoice");
        }
    }

    IEnumerator StartFade()
    {
        yield return new WaitForSeconds(2.0f);
        gameObject.SetActive(true);
        gameObject.gameObject.GetComponent<Text>().color = new Color32(255, 255, 255, 0);

        for (int i = 0; i < 255; i++)
        {
            yield return new WaitForSeconds(0.00001f);
            gameObject.gameObject.GetComponent<Text>().color = new Color32(255, 255, 255, (byte)(0 + i));
        }
        yield return new WaitForSeconds(2.0f);
        for (int i = 0; i < 127; i++)
        {
            yield return new WaitForSeconds(0.00001f);
            gameObject.gameObject.GetComponent<Text>().color = new Color32(255, 255, 255, (byte)(255 - i * 2));
        }
        yield return new WaitForSeconds(1.0f);
        gameObject.gameObject.GetComponent<Text>().color = new Color32(0, 0, 0, 0);
        StartCoroutine("EndFade");
    }

    IEnumerator EndFade()
    {
        yield return new WaitForSeconds(1.0f);
        endText.SetActive(true);
        endText.gameObject.GetComponent<Text>().color = new Color32(255, 255, 255, 0);

        for (int i = 0; i < 127; i++)
        {
            yield return new WaitForSeconds(0.00001f);
            endText.gameObject.GetComponent<Text>().color = new Color32(255, 255, 255, (byte)(0 + i * 2));
        }
        yield return new WaitForSeconds(1.0f);
        for (int i = 0; i < 127; i++)
        {
            yield return new WaitForSeconds(0.00001f);
            endText.gameObject.GetComponent<Text>().color = new Color32(255, 255, 255, (byte)(255 - i * 2));
        }
        
        endText.gameObject.GetComponent<Text>().color = new Color32(0, 0, 0, 0);
        StartCoroutine("SwitchScene");
    }

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(0.0f);
        SceneManager.LoadSceneAsync("PillChoice");
    }
}
