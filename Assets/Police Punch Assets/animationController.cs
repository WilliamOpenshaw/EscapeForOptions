using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public GameObject cop;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude > 0.1 )
        {
            cop.GetComponent<Animator>().SetBool("isMoving", true);
        }
         
        if (GetComponent<Rigidbody>().velocity.magnitude == 0 )
        {
            cop.GetComponent<Animator>().SetBool("isMoving", false);
        }

        
    }
    void Update() 
    {
         if (Input.GetMouseButtonDown(0))
        {
            cop.GetComponent<Animator>().SetBool("isPunching", true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            cop.GetComponent<Animator>().SetBool("isPunching", false);
        }
    }
    
}
