using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randomShout : MonoBehaviour
{
    public int shoutChoice;

    public AudioClip shout1;

    public AudioClip shout2;

    public AudioClip shout3;

    public AudioClip shout4;

    public AudioClip shout5;

    public AudioClip shout6;

    public AudioClip shout7;

    public AudioClip shout8;

    public AudioClip shout9;

    public AudioClip shout10;

    public AudioClip shout11;

    public AudioClip shout12;

    public AudioClip shout13;

    public AudioClip shout14;

    

    public AudioSource shoutSource;

    public float timeToWait;

    public GameObject shoutText;

    public TextMeshPro shoutTextMesh;

    // Start is called before the first frame update
    void Start()
    {
        shoutSource = GetComponent<AudioSource>();
        StartCoroutine("intervalShout");
        shoutText = gameObject.transform.Find("Shout3dtext").gameObject;
        TextMeshPro shoutTextMesh = shoutText.GetComponent<TextMeshPro>();
        shoutText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator intervalShout()
    {
        timeToWait = Random.Range(5.0f, 30.0f);
        
        yield return new WaitForSeconds(timeToWait);

        shoutChoice = Random.Range(1, 17);

        shoutSource.pitch = Random.Range(0.75f, 1.25f);

        shoutText.SetActive(true);

        switch (shoutChoice)
        {
            case 1:
                shoutSource.PlayOneShot(shout1, 1.0f);
                shoutTextMesh.text = "All I want right now is some air conditioning!";
                break;
            case 2:
                shoutSource.PlayOneShot(shout2, 1.0f);
                shoutTextMesh.text = "Everyone Hates You!";
                break;
            case 3:
                shoutSource.PlayOneShot(shout3, 1.0f);
                shoutTextMesh.text = "Get over here, hot stuff.";
                break;
            case 4:
                shoutSource.PlayOneShot(shout4, 1.0f);
                shoutTextMesh.text = "You Bitch!";
                break;
            case 5:
                shoutSource.PlayOneShot(shout5, 1.0f);
                shoutTextMesh.text = "I hope you find peace in your life.";
                break;
            case 6:
                shoutSource.PlayOneShot(shout6, 1.0f);
                shoutTextMesh.text = "I'm a big fan of your work.";
                break;
            case 7:
                shoutSource.PlayOneShot(shout7, 1.0f);
                shoutTextMesh.text = "I'm in so much pain.";
                break;
            case 8:
                shoutSource.PlayOneShot(shout8, 1.0f);
                shoutTextMesh.text = "It is such a beautiful day outside.";
                break;
            case 9:
                shoutSource.PlayOneShot(shout9, 1.0f);
                shoutTextMesh.text = "Oi Fuck You!";
                break;
            case 10:
                shoutSource.PlayOneShot(shout10, 1.0f);
                shoutTextMesh.text = "You Bitch.";
                break;
            case 11:
                shoutSource.PlayOneShot(shout11, 1.0f);
                shoutTextMesh.text = "I am big fan of your work.";
                break;
            case 12:
                shoutSource.PlayOneShot(shout12, 1.0f);
                shoutTextMesh.text = "You're a Bitch!";
                break;
            case 13:
                shoutSource.PlayOneShot(shout13, 1.0f);
                shoutTextMesh.text = "You look so good in that uniform.";
                break;
            case 14:
                shoutSource.PlayOneShot(shout14, 1.0f);
                shoutTextMesh.text = "You're doing a great job!";
                break;
                 
            
        }
        yield return new WaitForSeconds(10.0f);
        shoutText.SetActive(false);
        timeToWait = Random.Range(5.0f, 10.0f);
        yield return new WaitForSeconds(timeToWait);
        StartCoroutine("intervalShout");
    }
}
