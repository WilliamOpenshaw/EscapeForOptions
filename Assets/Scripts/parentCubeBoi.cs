using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentCubeBoi : MonoBehaviour
{
    public MoveRock rockMovement;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //other.gameObject.transform.SetParent(gameObject.transform.parent.transform , true);
            StopCoroutine(rockMovement.ForceRock());
            gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //other.gameObject.transform.SetParent(gameObject.transform.parent.transform , true);        
            gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            StartCoroutine(rockMovement.ForceRock());
        }
    }
    
}
