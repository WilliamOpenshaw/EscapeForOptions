using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickOpenPage : MonoBehaviour
{
    public Button patreonButton;

    public Button paypalButton;

    public Button cryptoButton;

    public bool clickDelayDone;

    // Start is called before the first frame update
    public void Start()
    {
        clickDelayDone = true;

        //Application.OpenURL("https://ophatapioka.bio.link/");

        patreonButton.onClick.AddListener (OpenPatreon);
        paypalButton.onClick.AddListener (OpenPaypal);
        cryptoButton.onClick.AddListener (OpenCrypto);

        Debug.Log("Listeners Started");
    }

    public void OpenPatreon()
    {
        if (clickDelayDone == true)
        {
            clickDelayDone = false;
            Application.OpenURL("https://www.patreon.com/ophatapioka");
            Debug.Log("Patreon Called");
            StartCoroutine(WaitNextClick());
        }
    }

    public void OpenPaypal()
    {
        if (clickDelayDone == true)
        {
            clickDelayDone = false;
            Application.OpenURL("https://www.paypal.com/paypalme/ophatapioka");
            Debug.Log("Paypal Called");
            StartCoroutine(WaitNextClick());
        }
    }

    public void OpenCrypto()
    {
        if (clickDelayDone == true)
        {
            clickDelayDone = false;
            Application.OpenURL("https://ophatapioka.bio.link/");
            Debug.Log("Crypto Called");
            StartCoroutine(WaitNextClick());
        }
    }

    public IEnumerator WaitNextClick()
    {
        yield return new WaitForSeconds(1.0f);
        clickDelayDone = true;
    }
}
