using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playVietnamVideos : MonoBehaviour
{
    public UnityEngine.Video.VideoClip video1;
    public UnityEngine.Video.VideoClip video2;
    public UnityEngine.Video.VideoClip video3;
    public UnityEngine.Video.VideoClip video4;
    public UnityEngine.Video.VideoClip video5;
    public UnityEngine.Video.VideoClip video6;
    public UnityEngine.Video.VideoClip video7;
    public UnityEngine.Video.VideoClip video8;
    public UnityEngine.Video.VideoClip video9;
    public UnityEngine.Video.VideoClip video10;
    public UnityEngine.Video.VideoClip video11;
    public int currentVideoNumber;

    //public GameObject tide;
    // Start is called before the first frame update
    void Start()
    {
        currentVideoNumber = Random.Range(1, 12);
        PlayVideos(currentVideoNumber);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (currentVideoNumber < 11)
            {
                PlayVideos(currentVideoNumber + 1);
            }
            else
            {
                PlayVideos(1);
            }
        }
    }
    void PlayVideos(int vidNum)
    {
        switch (vidNum)
        {
            case 1:
                StopAllCoroutines();
                currentVideoNumber = 1;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.4f);
                GetComponent<VideoPlayer>().clip = video1;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video1.length));
                break;
            case 2:
                StopAllCoroutines();
                currentVideoNumber = 2;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.3f);
                GetComponent<VideoPlayer>().clip = video2;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video2.length));
                break;
            case 3:
                StopAllCoroutines();
                currentVideoNumber = 3;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.3f);
                GetComponent<VideoPlayer>().clip = video3;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video3.length));
                break;
            case 4:
                StopAllCoroutines();
                currentVideoNumber = 4;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.3f);
                GetComponent<VideoPlayer>().clip = video4;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video4.length));
                break;
            case 5:
                StopAllCoroutines();
                currentVideoNumber = 5;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.4f);
                GetComponent<VideoPlayer>().clip = video5;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video5.length));
                break;
            case 6:
                StopAllCoroutines();
                currentVideoNumber = 6;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.2f);
                GetComponent<VideoPlayer>().clip = video6;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video6.length));
                break;
            case 7:
                StopAllCoroutines();
                currentVideoNumber = 7;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.3f);
                GetComponent<VideoPlayer>().clip = video7;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video7.length));
                break;
            case 8:
                StopAllCoroutines();
                currentVideoNumber = 8;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.025f);
                GetComponent<VideoPlayer>().clip = video8;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video8.length));
                break;
            case 9:
                StopAllCoroutines();
                currentVideoNumber = 9;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.2f);
                GetComponent<VideoPlayer>().clip = video9;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video9.length));
                break;
            case 10:
                StopAllCoroutines();
                currentVideoNumber = 10;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.3f);
                GetComponent<VideoPlayer>().clip = video10;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video10.length));
                break;
            case 11:
                StopAllCoroutines();
                currentVideoNumber = 11;
                GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.3f);
                GetComponent<VideoPlayer>().clip = video11;
                GetComponent<VideoPlayer>().Play();
                StartCoroutine(PlayNextVideoDelay((float)video11.length));
                break;
        }
    }

    IEnumerator PlayNextVideoDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (currentVideoNumber < 11)
        {
            PlayVideos(currentVideoNumber + 1);
        }
        else
        {
            PlayVideos(1);
        }
        
    }
}
