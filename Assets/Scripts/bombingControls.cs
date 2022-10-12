using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class bombingControls : MonoBehaviour
{
    public GameObject indicator;
    public GameObject map1;
    public GameObject map2;
    public GameObject map3;
    public GameObject mapStuff;
    public GameObject controlsPanel;
    public GameObject controlsText;
    public GameObject table;
    public GameObject instructionPaper;
    public int lastMap = 3;
    public bool bombing = false;

    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;
    public GameObject mark4;
    public GameObject mark5;
    public GameObject mark6;
    public GameObject mark7;
    public GameObject mark8;
    public GameObject mark9;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;

    public Text dayNumberText;

    public GameObject todayFriendly;
    public GameObject todayEnemy;
    public GameObject todayCivilian;
    public GameObject totalFriendly;
    public GameObject totalEnemy;
    public GameObject totalCivilian;

    public GameObject donationInfo;
    public GameObject fade;
    public GameObject tv;
    public GameObject offTV;
    public GameObject markConfines;
    public RectTransform confinesRect;
    public float savedTime2;
    //public GameObject gameVolume;

    public float daySeconds;
    public GameObject daySecondsUI;




    void Start()
    {
        donationInfo.SetActive(false);
        daySeconds = 20.0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        confinesRect = markConfines.GetComponent<RectTransform>();
        bombing = false;
        map1.SetActive(false);
        map2.SetActive(false);
        map3.SetActive(false);
        controlsPanel.SetActive(false);
        controlsText.SetActive(false);
        table.SetActive(false);
        mapStuff.SetActive(false);
        instructionPaper.SetActive(false);
        lastMap = 2;
        dayNumberText.text = Random.Range(12, 7300).ToString();
        totalFriendly.GetComponent<TextMeshProUGUI>().text = ((282000 / 50000) * (int.Parse(dayNumberText.text))).ToString("00000");
        totalEnemy.GetComponent<TextMeshProUGUI>().text = ((444000 / 50000) * (int.Parse(dayNumberText.text))).ToString("00000");
        totalCivilian.GetComponent<TextMeshProUGUI>().text = ((627000 / 50000) * (int.Parse(dayNumberText.text))).ToString("00000");
        todayFriendly.GetComponent<TextMeshProUGUI>().text = Random.Range(1, 20).ToString("00000");
        todayEnemy.GetComponent<TextMeshProUGUI>().text = Random.Range(1, 40).ToString("00000");
        todayCivilian.GetComponent<TextMeshProUGUI>().text = Random.Range(1, 60).ToString("00000");
        savedTime2 = 0.0f;
        //AudioListener.volume = 0.5f;
        //gameVolume.GetComponent<Text>().text = (AudioListener.volume * 100f).ToString("00");
        daySecondsUI.GetComponent<Text>().text = daySeconds.ToString();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B) && (bombing == false) && indicator.activeInHierarchy == true)
        {
            tv.GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.01f);
            bombing = true;
            mapStuff.SetActive(true);
            instructionPaper.SetActive(true);
            table.SetActive(true);
            GetComponent<RigidbodyFirstPersonController>().enabled = false;

            if (lastMap == 2)
            {
                map1.SetActive(false);
                map2.SetActive(true);
                map3.SetActive(false);
                lastMap = 2;
            }
            else if (lastMap == 3)
            {
                map1.SetActive(false);
                map2.SetActive(false);
                map3.SetActive(true);
                lastMap = 3;
            }
            else if (lastMap == 1)
            {
                map1.SetActive(true);
                map2.SetActive(false);
                map3.SetActive(false);
                lastMap = 1;
            }
            StartCoroutine(nameof(changeMaps), daySeconds);
            //dayNumberText.text = (int.Parse(dayNumberText.text) + 1).ToString();
            mark1.SetActive(false);
            mark2.SetActive(false);
            mark3.SetActive(false);
            mark4.SetActive(false);
            mark5.SetActive(false);
            mark6.SetActive(false);
            mark7.SetActive(false);
            mark8.SetActive(false);
            mark9.SetActive(false);
            mark10.SetActive(false);
            mark11.SetActive(false);
            mark12.SetActive(false);
            mark1.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark2.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark3.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark4.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark5.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark6.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark7.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark8.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark9.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark10.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark11.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark12.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark1.SetActive(true);
            mark2.SetActive(true);
            mark3.SetActive(true);
            mark4.SetActive(true);
            mark5.SetActive(true);
            mark6.SetActive(true);
            mark7.SetActive(true);
            mark8.SetActive(true);
            mark9.SetActive(true);
            mark10.SetActive(true);
            mark11.SetActive(true);
            mark12.SetActive(true);

        }
        else if (Input.GetKeyDown(KeyCode.B) && bombing == true)
        {

            bombing = false;
            tv.GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.3f);
            table.SetActive(false);
            mapStuff.SetActive(false);
            instructionPaper.SetActive(false);
            GetComponent<RigidbodyFirstPersonController>().enabled = true;
            map1.SetActive(false);
            map2.SetActive(false);
            map3.SetActive(false);
            StopCoroutine("changeMaps");
        }
        if (Input.GetKeyDown(KeyCode.Escape) && controlsPanel.activeSelf == true)
        {
            controlsPanel.SetActive(false);
            controlsText.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && controlsPanel.activeSelf == false)
        {
            controlsPanel.SetActive(true);
            controlsText.SetActive(true);
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
        
        if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
        {
            Application.Quit();
        }
        
        if (Input.GetKeyDown(KeyCode.V) && tv.activeSelf == true)
        {
            tv.SetActive(false);
            offTV.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.V) && tv.activeSelf == false)
        {
            tv.SetActive(true);
            offTV.SetActive(false);
            tv.GetComponent<VideoPlayer>().Play();
        }
        
        /*
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
        */
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (daySeconds > 6.0f)
            {
                daySeconds -= 5.0f;
                daySecondsUI.GetComponent<Text>().text = daySeconds.ToString();
            }

        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (daySeconds < 180.0f)
            {
                daySeconds += 5.0f;
                daySecondsUI.GetComponent<Text>().text = daySeconds.ToString();
            }

        }

    }
    private IEnumerator changeMaps(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        fade.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(1.5f);
        //print("WaitAndPrint " + Time.time);
        if (lastMap == 1)
        {
            map1.SetActive(false);
            map2.SetActive(true);
            map3.SetActive(false);
            lastMap = 2;
            StartCoroutine(nameof(changeMaps), daySeconds);
            dayNumberText.text = (int.Parse(dayNumberText.text) + 1).ToString();
            mark1.SetActive(false);
            mark2.SetActive(false);
            mark3.SetActive(false);
            mark4.SetActive(false);
            mark5.SetActive(false);
            mark6.SetActive(false);
            mark7.SetActive(false);
            mark8.SetActive(false);
            mark9.SetActive(false);
            mark10.SetActive(false);
            mark11.SetActive(false);
            mark12.SetActive(false);
            mark1.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark2.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark3.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark4.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark5.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark6.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark7.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark8.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark9.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark10.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark11.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark12.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark1.SetActive(true);
            mark2.SetActive(true);
            mark3.SetActive(true);
            mark4.SetActive(true);
            mark5.SetActive(true);
            mark6.SetActive(true);
            mark7.SetActive(true);
            mark8.SetActive(true);
            mark9.SetActive(true);
            mark10.SetActive(true);
            mark11.SetActive(true);
            mark12.SetActive(true);
        }
        else if (lastMap == 2)
        {
            map1.SetActive(false);
            map2.SetActive(false);
            map3.SetActive(true);
            lastMap = 3;
            StartCoroutine(nameof(changeMaps), daySeconds);
            dayNumberText.text = (int.Parse(dayNumberText.text) + 1).ToString();
            mark1.SetActive(false);
            mark2.SetActive(false);
            mark3.SetActive(false);
            mark4.SetActive(false);
            mark5.SetActive(false);
            mark6.SetActive(false);
            mark7.SetActive(false);
            mark8.SetActive(false);
            mark9.SetActive(false);
            mark10.SetActive(false);
            mark11.SetActive(false);
            mark12.SetActive(false);
            mark1.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark2.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark3.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark4.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark5.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark6.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark7.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark8.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark9.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark10.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark11.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark12.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark1.SetActive(true);
            mark2.SetActive(true);
            mark3.SetActive(true);
            mark4.SetActive(true);
            mark5.SetActive(true);
            mark6.SetActive(true);
            mark7.SetActive(true);
            mark8.SetActive(true);
            mark9.SetActive(true);
            mark10.SetActive(true);
            mark11.SetActive(true);
            mark12.SetActive(true);
        }
        else if (lastMap == 3)
        {
            map1.SetActive(true);
            map2.SetActive(false);
            map3.SetActive(false);
            lastMap = 1;
            StartCoroutine(nameof(changeMaps), daySeconds);
            dayNumberText.text = (int.Parse(dayNumberText.text) + 1).ToString();
            mark1.SetActive(false);
            mark2.SetActive(false);
            mark3.SetActive(false);
            mark4.SetActive(false);
            mark5.SetActive(false);
            mark6.SetActive(false);
            mark7.SetActive(false);
            mark8.SetActive(false);
            mark9.SetActive(false);
            mark10.SetActive(false);
            mark11.SetActive(false);
            mark12.SetActive(false);
            mark1.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark2.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark3.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark4.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark5.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark6.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark7.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark8.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark9.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark10.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark11.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark12.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width / -2.1f, confinesRect.rect.width / 2.1f), Random.Range(confinesRect.rect.height / -2.1f, confinesRect.rect.height / 2.1f), 0);
            mark1.SetActive(true);
            mark2.SetActive(true);
            mark3.SetActive(true);
            mark4.SetActive(true);
            mark5.SetActive(true);
            mark6.SetActive(true);
            mark7.SetActive(true);
            mark8.SetActive(true);
            mark9.SetActive(true);
            mark10.SetActive(true);
            mark11.SetActive(true);
            mark12.SetActive(true);
        }
        //reset daily numbers and add daily to totals
        totalFriendly.GetComponent<TextMeshProUGUI>().text = (int.Parse(totalFriendly.GetComponent<TextMeshProUGUI>().text) + int.Parse(todayFriendly.GetComponent<TextMeshProUGUI>().text)).ToString("00000");
        totalEnemy.GetComponent<TextMeshProUGUI>().text = (int.Parse(totalEnemy.GetComponent<TextMeshProUGUI>().text) + int.Parse(todayEnemy.GetComponent<TextMeshProUGUI>().text)).ToString("00000");
        totalCivilian.GetComponent<TextMeshProUGUI>().text = (int.Parse(totalCivilian.GetComponent<TextMeshProUGUI>().text) + int.Parse(todayCivilian.GetComponent<TextMeshProUGUI>().text)).ToString("00000");
        todayFriendly.GetComponent<TextMeshProUGUI>().text = Random.Range(1, 5).ToString("00000");
        todayEnemy.GetComponent<TextMeshProUGUI>().text = Random.Range(1, 10).ToString("00000");
        todayCivilian.GetComponent<TextMeshProUGUI>().text = Random.Range(1, 15).ToString("00000");
    }
}
