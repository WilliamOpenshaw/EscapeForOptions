using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunChangeTrigger : MonoBehaviour
{
    public firePlayerGun gunShapeChange;
    public GameObject gunPickUpMessage;
    void Start()
    {
        gunPickUpMessage .SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (other.CompareTag("Player"))
            {       
                gunShapeChange.RandomizeWeaponAndProjectile();   
                gunPickUpMessage.SetActive(false);
                gameObject.SetActive(false);       
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gunPickUpMessage.SetActive(true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gunPickUpMessage .SetActive(false);
        }
    }
}
