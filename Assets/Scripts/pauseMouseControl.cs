using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class pauseMouseControl : MonoBehaviour
{
    public RigidbodyFirstPersonController rfpc;
    // Start is called before the first frame update
    void Start()
    {
        rfpc = gameObject.GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.O) &&  gameObject.GetComponent<RigidbodyFirstPersonController>().enabled == true)
        {
            gameObject.GetComponent<RigidbodyFirstPersonController>().enabled = false;

        } else if (Input.GetKey(KeyCode.O) &&  gameObject.GetComponent<RigidbodyFirstPersonController>().enabled == false )
        {
            gameObject.GetComponent<RigidbodyFirstPersonController>().enabled = true;
        }
    }
}
