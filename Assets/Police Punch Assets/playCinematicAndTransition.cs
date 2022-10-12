using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class playCinematicAndTransition : MonoBehaviour
{
    public Text pressText;
    public Text ESCText;
    //public Text ESCTextB;
    public UnityEngine.Video.VideoPlayer vP;
    public bool videoStarted;
    public VideoClip policeClip;
    public string errorMessage;
    public GameObject textBG;
    
     // Start is called before the first frame update
    void Start()
    {
        vP = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoStarted = false;
        ESCText.text = "";
        //ESCTextB.text = "";
        pressText.text = "Press any key to play video...";
        textBG.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        vP.errorReceived += ErrorReceived;

        if(Input.anyKey)
        {
            vP.Play();
            vP.isLooping = false;
            pressText.text = "";
            textBG.SetActive(true);
            ESCText.text = "Press ESC Escape key to skip...";
           // ESCTextB.text = "Press ESC Escape key to skip or if video is not playing...";
        }

         if(vP.isPlaying == true)
        {
            videoStarted = true;
        }

        if(videoStarted == true && vP.isPlaying == false)
        {
            SceneManager.LoadScene("Police Punch Scene", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Police Punch Scene", LoadSceneMode.Single);
        }

        
    }

    public void ErrorReceived(VideoPlayer vP, string message)
    {
        Debug.Log(message);
        vP.clip = policeClip;
        vP.Play();
        vP.isLooping = false;
    }
}
