using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.CrossPlatformInput;

public class fovAndDonationButton : MonoBehaviour
{
    public GameObject player;
    
    public Text mouseSensativityTextX;

    public Text mouseSensativityTextY;

    public Camera playerCamera;
    
    public GameObject donationMenu;

    public GameObject cryptoMenu;

    public GameObject creditsInfo;

    public Text fovText;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        donationMenu.SetActive(false);
        cryptoMenu.SetActive(false);
        fovText.text = playerCamera.fieldOfView.ToString();

        
        mouseSensativityTextX.text =
            player
                .GetComponent<RigidbodyFirstPersonController>()
                .mouseLook
                .XSensitivity
                .ToString();
        mouseSensativityTextY.text =
            player
                .GetComponent<RigidbodyFirstPersonController>()
                .mouseLook
                .YSensitivity
                .ToString();
    }

    // Update is called once per frame
    void Update()
    {

        //MOUSE SENSATIVITY CONTROLS
        //X SENSATIVITY
        if (
            Input.GetKeyDown(KeyCode.Keypad5) ||
            Input.GetKeyDown(KeyCode.Alpha5)
        )
        {
            player
                .GetComponent<RigidbodyFirstPersonController>()
                .mouseLook
                .XSensitivity -= 1.0f;
            mouseSensativityTextX.text =
                player
                    .GetComponent<RigidbodyFirstPersonController>()
                    .mouseLook
                    .XSensitivity
                    .ToString();
        }

        if (
            Input.GetKeyDown(KeyCode.Keypad6) ||
            Input.GetKeyDown(KeyCode.Alpha6)
        )
        {
            player
                .GetComponent<RigidbodyFirstPersonController>()
                .mouseLook
                .XSensitivity += 1.0f;
            mouseSensativityTextX.text =
                player
                    .GetComponent<RigidbodyFirstPersonController>()
                    .mouseLook
                    .XSensitivity
                    .ToString();
        }

        //Y SENSATIVITY
        if (
            Input.GetKeyDown(KeyCode.Keypad7) ||
            Input.GetKeyDown(KeyCode.Alpha7)
        )
        {
            player
                .GetComponent<RigidbodyFirstPersonController>()
                .mouseLook
                .YSensitivity -= 1.0f;
            mouseSensativityTextY.text =
                player
                    .GetComponent<RigidbodyFirstPersonController>()
                    .mouseLook
                    .YSensitivity
                    .ToString();
        }

        if (
            Input.GetKeyDown(KeyCode.Keypad8) ||
            Input.GetKeyDown(KeyCode.Alpha8)
        )
        {
            player
                .GetComponent<RigidbodyFirstPersonController>()
                .mouseLook
                .YSensitivity += 1.0f;
            mouseSensativityTextY.text =
                player
                    .GetComponent<RigidbodyFirstPersonController>()
                    .mouseLook
                    .YSensitivity
                    .ToString();
        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            creditsInfo.SetActive(!creditsInfo.activeSelf);
        }

        if (
            Input.GetKeyDown(KeyCode.Slash) ||
            Input.GetKeyDown(KeyCode.Question)
        )
        {
            donationMenu.SetActive(!donationMenu.activeSelf);

            if (donationMenu.activeSelf == true)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else if (donationMenu.activeSelf == false)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (
            Input.GetKeyDown(KeyCode.Keypad3) ||
            Input.GetKeyDown(KeyCode.Alpha3)
        )
        {
            playerCamera.fieldOfView -= 5.0f;
            fovText.text = playerCamera.fieldOfView.ToString();
        }

        if (
            Input.GetKeyDown(KeyCode.Keypad4) ||
            Input.GetKeyDown(KeyCode.Alpha4)
        )
        {
            playerCamera.fieldOfView += 5.0f;
            fovText.text = playerCamera.fieldOfView.ToString();
        }
    }
}
