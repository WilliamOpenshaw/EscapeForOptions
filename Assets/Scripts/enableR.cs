using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableR : MonoBehaviour
{
    public static bool rAppear;
    public GameObject redText;
    // Start is called before the first frame update
    void Start()
    {
        rAppear = false;
        redText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (rAppear == true)
        {
            redText.SetActive(true);
        }
        else if (rAppear == false)
        {
            redText.SetActive(false);
        }

    }
}