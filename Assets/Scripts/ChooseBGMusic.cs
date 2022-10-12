using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBGMusic : MonoBehaviour
{
    public AudioSource musicBG1;
    public AudioSource musicBG2;
    public AudioSource musicBG3;
    public AudioSource musicBG4;
    public AudioSource musicBG5;
    public AudioSource currentBGMusic;
    public int currentBGMusicNum;
    
    void Start()
    {
                
        currentBGMusicNum = Random.Range(1, 6);
        switch (currentBGMusicNum)
        {
            case 1:
                currentBGMusic = musicBG1; break;
            case 2:
                currentBGMusic = musicBG2; break;
            case 3:
                currentBGMusic = musicBG3; break;
            case 4:
                currentBGMusic = musicBG4; break;
            case 5:
                currentBGMusic = musicBG5; break;       
        }
        currentBGMusic.volume = 0.5f;
        currentBGMusic.Play();
        StartCoroutine("PlayNextClip", currentBGMusic.clip.length);
        
        
    }
    public IEnumerator PlayNextClip(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        currentBGMusic.Stop();
        currentBGMusicNum = Random.Range(1, 6);
        switch (currentBGMusicNum)
        {
            case 1:
                currentBGMusic = musicBG1; break;
            case 2:
                currentBGMusic = musicBG2; break;
            case 3:
                currentBGMusic = musicBG3; break;
            case 4:
                currentBGMusic = musicBG4; break;
            case 5:
                currentBGMusic = musicBG5; break;       
        }
        currentBGMusic.volume = 0.5f;
        currentBGMusic.Play();
        StartCoroutine("PlayNextClip", currentBGMusic.clip.length);
    }
    
}
