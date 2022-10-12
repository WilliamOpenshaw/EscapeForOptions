using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightUp : MonoBehaviour
{
    public GameObject highlight1;
    public GameObject highlight2;
    public GameObject highlight3;
    //public GameObject goText1;
    public GameObject goText2;
    //public GameObject goText3;
    // Start is called before the first frame update
    void Start()
    {
        highlight1.SetActive(false);
        highlight2.SetActive(false);
        highlight3.SetActive(false);
        //goText1.SetActive(false);
        goText2.SetActive(false);
        //goText3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
       
        if (other.tag == "Highlight")
        {
            highlight1.SetActive(true);
            highlight2.SetActive(true);
            highlight3.SetActive(true);
            //goText1.SetActive(true);
            goText2.SetActive(true);
            //goText3.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.tag == "Highlight")
        {
            highlight1.SetActive(false);
            highlight2.SetActive(false);
            highlight3.SetActive(false);
            //goText1.SetActive(false);
            goText2.SetActive(false);
            //goText3.SetActive(false);
        }
    }
}
