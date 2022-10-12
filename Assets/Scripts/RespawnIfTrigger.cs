using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnIfTrigger : MonoBehaviour
{
    //public Transform respawnPoint;
    public int spawnChoice;

    //public Transform direction;
    public Transform center;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Platform")
        {
            other.gameObject.transform.GetChild(0).transform.LookAt(center);
            other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.GetChild(0).transform.forward * UnityEngine.Random.Range(1000, 2000), ForceMode.Impulse);
        }
        else 
        {
            spawnChoice = UnityEngine.Random.Range(1,  GameObject.FindGameObjectsWithTag("EnemySpawn").Length + 1);
            if (other.gameObject.GetComponent<Rigidbody>() != null)
            {
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            other.gameObject.transform.position = GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnChoice].transform.position;
        }
    }

}
