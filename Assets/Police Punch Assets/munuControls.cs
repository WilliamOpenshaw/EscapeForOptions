using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.CrossPlatformInput;

public class munuControls : MonoBehaviour
{
    public AudioSource bgMusicAudioSource;

    public GameObject player;

    public GameObject controlsMenu;

    public GameObject donationMenu;

    public GameObject cryptoMenu;

    public GameObject credits;

    public Text fovText;

    public Text volumeText;

    public Text mouseSensativityTextX;

    public Text mouseSensativityTextY;

    public Camera playerCamera;

    public GameObject playerCameraObject;

    public GameObject audioListener;

    public float audioVolume;

    // Start is called before the first frame update
    void Start()
    {
        audioVolume = AudioListener.volume;
        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        volumeText.text = (bgMusicAudioSource.volume * 10.0f).ToString("0");
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

        //FOV CONTROL
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

        //VOLUME CONTROL
        if (
            Input.GetKeyDown(KeyCode.Keypad1) ||
            Input.GetKeyDown(KeyCode.Alpha1) &&
            audioVolume > 0.1f
        )
        {
            AudioListener.volume -= 0.1f;
            audioVolume = AudioListener.volume;
            //audioListener.volume -= 0.1f;
            volumeText.text = (audioVolume * 10.0f).ToString("0");
        }
        if (
            Input.GetKeyDown(KeyCode.Keypad2) ||
            Input.GetKeyDown(KeyCode.Alpha2) &&
            audioVolume < 0.9f
        )
        {
           AudioListener.volume += 0.1f;
           audioVolume = AudioListener.volume;
            //audioListener.volume -= 0.1f;
            volumeText.text = (audioVolume * 10.0f).ToString("0");
        }

        //CONTROLS MENU TOGGLE
        if (Input.GetKeyDown(KeyCode.Escape) && controlsMenu.activeSelf == false
        )
        {
            controlsMenu.SetActive(true);
        }
        else if (
            Input.GetKeyDown(KeyCode.Escape) && controlsMenu.activeSelf == true
        )
        {
            controlsMenu.SetActive(false);
        }

        //DONATION MENU CONTROL
        if (
            Input.GetKeyDown("/") && donationMenu.activeSelf == false ||
            Input.GetKeyDown("?") && donationMenu.activeSelf == false
        )
        {
            donationMenu.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (
            Input.GetKeyDown("/") && donationMenu.activeSelf == true ||
            Input.GetKeyDown("?") && donationMenu.activeSelf == true
        )
        {
            donationMenu.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        /*
        if (
            Input.GetKeyDown(KeyCode.P) &&  cryptoMenu.activeSelf == false
            
        )
        {
            cryptoMenu.SetActive(true);
        }
        else if (
            Input.GetKeyDown(KeyCode.P) &&  cryptoMenu.activeSelf == true
           
        )
        {
            cryptoMenu.SetActive(false);
        }
        */
        //CREDITS INFO TOGGLE
        if (Input.GetKeyDown(KeyCode.L) && credits.activeSelf == false)
        {
            credits.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.L) && credits.activeSelf == true)
        {
            credits.SetActive(false);
        }

        //QUIT
        if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
        {
            Application.Quit();
        }
    }
}
