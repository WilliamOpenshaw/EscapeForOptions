using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalKeyTrigger : MonoBehaviour
{
    public GameObject portal;

    public GameObject portalLight;

    public GameObject portalKey1;

    public GameObject portalKey2;

    public GameObject portalKey3;

    public GameObject portalKey4;

    public bool playerEntered;

    public GameObject activationMessage;

    public Color blueShine = new Color32(0, 136, 191, 255);

    void Start()
    {
        playerEntered = false;

        //blueShine = blueShine * 1.0f;
        gameObject
            .transform
            .GetChild(0)
            .GetComponent<Renderer>()
            .material
            .SetColor("_EmissionColor", Color.black);
        blueShine = blueShine * 0.002f;

        //blueShine = blueShine * 0.3f;
        //gameObject.transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_EmissionColor", blueShine );
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        portal.SetActive(false);
        portalLight.SetActive(false);
        activationMessage.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerEntered == true)
        {
            gameObject
                .transform
                .GetChild(0)
                .GetComponent<Renderer>()
                .material
                .SetColor("_EmissionColor", blueShine);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            activationMessage.SetActive(false);
            if (
                    portalKey1.transform.GetChild(1).gameObject.activeSelf == true &&
                    portalKey2.transform.GetChild(1).gameObject.activeSelf == true &&
                    portalKey3.transform.GetChild(1).gameObject.activeSelf == true &&
                    portalKey4.transform.GetChild(1).gameObject.activeSelf == true
                )
            {
                portal.SetActive(true);
                portalLight.SetActive(true);
            }
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerEntered = true;
            if (gameObject.transform.GetChild(1).gameObject.activeSelf == false)
            {
                activationMessage.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            activationMessage.SetActive(false);
        }
    }

    public void ResetKeys()
    {
        gameObject
            .transform
            .GetChild(0)
            .GetComponent<Renderer>()
            .material
            .SetColor("_EmissionColor", Color.black);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        portal.SetActive(false);
        portalLight.SetActive(false);
    }
}
