using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableB : MonoBehaviour
{
    public static bool bAppear;
    public GameObject blueText;
    // Start is called before the first frame update
    void Start()
    {
        bAppear = false;
        blueText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(bAppear == true)
        {
            blueText.SetActive(true);
        } else if(bAppear == false)
        {
            blueText.SetActive(false);
        }

    }
}
