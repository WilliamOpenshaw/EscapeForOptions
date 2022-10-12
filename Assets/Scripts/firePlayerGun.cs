using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
public class firePlayerGun : MonoBehaviour
{
    public GameObject projectileBulletProto;

    public Transform projSpawnPoint;
    //public Transform bulletCharacteristics;
    public int bulletModeNumber;
    public GameObject gunBodyBox1;
    public GameObject gunBodyBox2;
    public GameObject gunBodyBox3;
    public GameObject gunBodyBox4;
    public GameObject gunBodyBox5;
    public GameObject gunBodyBox6;
    public GameObject gunBodyBox7;
    public GameObject gunBodyBox8;
    public GameObject gunBodyBox9;
    public GameObject gunBodyBox10;
    public GameObject gunBodyBox11;
    public GameObject gunBodyBox12;
    public GameObject gunBodyBox13;
    public GameObject gunBodyBox14;
    public GameObject gunBodyBox15;
    public GameObject gunBodyBox16;

    public Color randomColor;
    public GameObject currBulletDir1;
    public GameObject currBulletDir2;
    public GameObject currBulletDir3;
    public GameObject currBulletDir4;
    public GameObject currBulletDir5;

    public AudioSource pew1;
    public AudioSource pew2;
    public AudioSource pew3;
    public AudioSource pew4;

    public AudioSource pew5;
    public AudioSource pew6;
    public AudioSource pew7;
    public AudioSource pew8;
    public AudioSource pew9;
    public AudioSource pew10;
    public float savedTime;
    public float savedTime2;
    public GameObject gameVolume;

    public AudioSource currentGunSound;
    public int soundChoiceNum;

    public float currentWaitTime;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        savedTime = 0.0f;
        savedTime2 = 0.0f;
        RandomizeWeaponAndProjectile();
        StartCoroutine(deleteBullets());
        AudioListener.volume = 0.5f;
        gameVolume.GetComponent<Text>().text = (AudioListener.volume * 100f).ToString("00");

        soundChoiceNum = Random.Range(1, 11);
        switch (soundChoiceNum)
        {
            case 1:
                currentGunSound = pew1; break;
            case 2:
                currentGunSound = pew2; break;
            case 3:
                currentGunSound = pew3; break;
            case 4:
                currentGunSound = pew4; break;
            case 5:
                currentGunSound = pew5; break;
            case 6:
                currentGunSound = pew6; break;
            case 7:
                currentGunSound = pew7; break;
            case 8:
                currentGunSound = pew8; break;
            case 9:
                currentGunSound = pew9; break;
            case 10:
                currentGunSound = pew10; break;

        }

        pew1.volume = 0.01f;
        pew2.volume = 0.01f;
        pew3.volume = 0.01f;
        pew4.volume = 0.01f;
        pew5.volume = 0.01f;
        pew6.volume = 0.01f;
        pew7.volume = 0.01f;
        pew8.volume = 0.01f;
        pew9.volume = 0.01f;
        pew10.volume = 0.01f;

    }
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            if (Time.time > savedTime + 0.1f)
            {
                
                currentGunSound.Stop();
                currentGunSound.Play();
                savedTime = Time.time;
            }
            GameObject projectileBullet = Instantiate(projectileBulletProto, projSpawnPoint.transform.position, projectileBulletProto.transform.rotation) as GameObject;
            projectileBullet.gameObject.tag = "Bullet";
            projectileBullet.GetComponent<Rigidbody>().AddForce(projSpawnPoint.transform.forward * 500);
            StartCoroutine(changeBulletVelocity(currentWaitTime, projectileBullet));
        }
        if (Input.GetMouseButtonUp(0))
        {
            currentGunSound.Stop();
        }
        if (Input.GetKey(KeyCode.Keypad1) || Input.GetKey(KeyCode.Alpha1))
        {
              if (Time.time > savedTime2 + 0.01f && AudioListener.volume > 0.01f)
            {
                
            AudioListener.volume = AudioListener.volume - 0.01f;
            gameVolume.GetComponent<Text>().text = (AudioListener.volume * 100f).ToString("00");
            savedTime2 = Time.time;
            }
        }
        if (Input.GetKey(KeyCode.Keypad2) || Input.GetKey(KeyCode.Alpha2))
        {
             if (Time.time > savedTime2 + 0.01f && AudioListener.volume < 0.99f)
            {                
            AudioListener.volume = AudioListener.volume + 0.01f;
            gameVolume.GetComponent<Text>().text = (AudioListener.volume * 100f).ToString("00");
            savedTime2 = Time.time;
            }
           
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            RandomizeWeaponAndProjectile();
        }


    }
    public void RandomizeWeaponAndProjectile()
    {
        soundChoiceNum = Random.Range(1, 11);
        switch (soundChoiceNum)
        {
            case 1:
                currentGunSound = pew1; break;
            case 2:
                currentGunSound = pew2; break;
            case 3:
                currentGunSound = pew3; break;
            case 4:
                currentGunSound = pew4; break;
            case 5:
                currentGunSound = pew5; break;
            case 6:
                currentGunSound = pew6; break;
            case 7:
                currentGunSound = pew7; break;
            case 8:
                currentGunSound = pew8; break;
            case 9:
                currentGunSound = pew9; break;
            case 10:
                currentGunSound = pew10; break;

        }
        StartCoroutine(deleteBullets());
        //Gun Body
        //Color        
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox1.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox2.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox3.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox4.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox5.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox6.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox7.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox8.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox9.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox10.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox11.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox12.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox13.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox14.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox15.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox16.GetComponent<Renderer>().material.SetColor("_Color", randomColor);

        //emissionColor

        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox1.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox2.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox3.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox4.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox5.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox6.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox7.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox8.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox9.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox10.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox11.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox12.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox13.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox14.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox15.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        gunBodyBox16.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);

        //location
        gunBodyBox1.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox2.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox3.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox4.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox5.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox6.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox7.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox8.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox9.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
        Random.Range(0.5f, 1.104f));
        gunBodyBox10.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox11.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox12.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox13.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox14.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox15.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        gunBodyBox16.transform.localPosition = new Vector3(Random.Range(0.35f, 1.0f), Random.Range(0.178f, 0.66f),
            Random.Range(0.5f, 1.104f));
        //scale
        gunBodyBox1.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
        Random.Range(0.01f, 1.0f));
        gunBodyBox2.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox3.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox4.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox5.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox6.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox7.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox8.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox9.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox10.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox11.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox12.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox13.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox14.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox15.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        gunBodyBox16.transform.localScale = new Vector3(Random.Range(0.01f, 0.3f), Random.Range(0.01f, 0.3f),
            Random.Range(0.01f, 1.0f));
        //rotation

        gunBodyBox1.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox2.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox3.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox4.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox5.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox6.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox7.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox8.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox9.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox10.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox11.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox12.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox13.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox14.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox15.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gunBodyBox16.transform.localRotation = Quaternion.Euler(0, 0, 0);

        bulletModeNumber = UnityEngine.Random.Range(1, 3);
        if (bulletModeNumber == 2)
        {
            gunBodyBox1.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox2.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox3.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox4.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox5.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox6.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox7.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox8.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox9.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox10.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox11.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox12.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox13.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox14.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox15.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
            gunBodyBox16.transform.localRotation = Quaternion.Euler(Random.Range(-30, 30), Random.Range(-30, 30),
                Random.Range(-30, 30));
        }

        //Bullet
        projectileBulletProto.transform.localRotation = Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360),
            Random.Range(-360, 360));
        projectileBulletProto.transform.localScale = new Vector3(Random.Range(0.1f, 0.5f), Random.Range(0.1f, 0.5f),
            Random.Range(0.1f, 0.5f));
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            1.0f);
        projectileBulletProto.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        projectileBulletProto.GetComponent<Renderer>().material.SetColor("_EmissionColor", randomColor);
        currentWaitTime = Random.Range(0.001f, 0.05f);

        currBulletDir1.transform.localRotation = Quaternion.Euler(0, 0, 0);
        currBulletDir2.transform.localRotation = Quaternion.Euler(0, 0, 0);
        currBulletDir3.transform.localRotation = Quaternion.Euler(0, 0, 0);
        currBulletDir4.transform.localRotation = Quaternion.Euler(0, 0, 0);
        currBulletDir5.transform.localRotation = Quaternion.Euler(0, 0, 0);

        currBulletDir1.transform.localRotation = Quaternion.Euler(Random.Range(-45, 45), Random.Range(-45, 45),
            Random.Range(-45, 45));
        currBulletDir2.transform.localRotation = Quaternion.Euler(Random.Range(-45, 45), Random.Range(-45, 45),
            Random.Range(-45, 45));
        currBulletDir3.transform.localRotation = Quaternion.Euler(Random.Range(-45, 45), Random.Range(-45, 45),
            Random.Range(-45, 45));
        currBulletDir4.transform.localRotation = Quaternion.Euler(Random.Range(-45, 45), Random.Range(-45, 45),
            Random.Range(-45, 45));
        currBulletDir5.transform.localRotation = Quaternion.Euler(Random.Range(-45, 45), Random.Range(-45, 45),
            Random.Range(-45, 45));

        bulletModeNumber = Random.Range(1, 5);
    }
    private IEnumerator changeBulletVelocity(float waitTime, GameObject currentProjectile)
    {
        switch (bulletModeNumber)
        {
            case 1:
                yield return new WaitForSeconds(waitTime);
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir1.transform.forward * 500);
                break;
            case 2:
                yield return new WaitForSeconds(waitTime);
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir1.transform.forward * 500);
                yield return new WaitForSeconds(waitTime);
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir2.transform.forward * 500);
                break;

            case 3:
                yield return new WaitForSeconds(waitTime);
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir1.transform.forward * 500);

                yield return new WaitForSeconds(waitTime);
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir2.transform.forward * 500);

                yield return new WaitForSeconds(waitTime);
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir3.transform.forward * 500);

                break;
            case 4:
                yield return new WaitForSeconds(waitTime);
                currBulletDir1.transform.localRotation = Quaternion.Euler(Random.Range(-45, 45), Random.Range(-45, 45),
                    Random.Range(-45, 45));
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir1.transform.forward * 500);

                yield return new WaitForSeconds(waitTime);
                currBulletDir2.transform.localRotation = Quaternion.Euler(Random.Range(-45, 45), Random.Range(-45, 45),
                    Random.Range(-45, 45));
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir2.transform.forward * 500);

                yield return new WaitForSeconds(waitTime);
                currBulletDir3.transform.localRotation = Quaternion.Euler(Random.Range(-45, 45), Random.Range(-45, 45),
                    Random.Range(-45, 45));
                currentProjectile.GetComponent<Rigidbody>().AddForce(currBulletDir3.transform.forward * 500);
                break;
        }
    }
    public IEnumerator deleteBullets()
    {
        yield return new WaitForSeconds(0.05f);
        if (GameObject.FindGameObjectWithTag("Bullet") != null)
        {
            Destroy(GameObject.FindGameObjectWithTag("Bullet"));
            StartCoroutine(deleteBullets());
        }
    }
}
