using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnIfTriggerRock : MonoBehaviour
{
    //public Transform direction;
    public Transform center;
     void OnTriggerStay (Collider other)
     {
         if (other.gameObject.tag == "Platform")
        {
            other.gameObject.transform.GetChild(0).transform.LookAt(center);
            other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.GetChild(0).transform.forward * UnityEngine.Random.Range(1000, 2000), ForceMode.Impulse);
        }
     }     
}
