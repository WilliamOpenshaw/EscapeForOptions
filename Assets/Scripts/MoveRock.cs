using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveRock : MonoBehaviour
{
    void Start()
    {
        if(gameObject.name == "New Starship")
        {
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, Random.Range(-360.0f, 360.0f));
        } 
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, Random.Range(-360.0f, 360.0f), 0);
        }
        //gameObject.transform.rotation = Quaternion.Euler(0, Random.Range(-360.0f, 360.0f), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(Random.Range(-2000.0f, 2000.0f), Random.Range(-2000.0f, 2000.0f), Random.Range(-2000.0f, 2000.0f), ForceMode.Impulse);
        StartCoroutine(ForceRock());
    }
    void OnEnable()
    {
        if(gameObject.name == "New Starship")
        {
            //gameObject.transform.rotation = Quaternion.Euler(0, 0, Random.Range(-360.0f, 360.0f));
        } 
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, Random.Range(-360.0f, 360.0f), 0);
        }
        //gameObject.transform.rotation = Quaternion.Euler(0, Random.Range(-360.0f, 360.0f), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(Random.Range(-2000.0f, 2000.0f), Random.Range(-2000.0f, 2000.0f), Random.Range(-2000.0f, 2000.0f), ForceMode.Impulse);
        StartCoroutine(ForceRock());
    }
    public IEnumerator ForceRock()
    {
        yield return new WaitForSeconds(Random.Range(10.0f, 20.0f));
        gameObject.GetComponent<Rigidbody>().AddForce(Random.Range(-2000.0f, 2000.0f), Random.Range(-2000.0f, 2000.0f), Random.Range(-2000.0f, 2000.0f), ForceMode.Impulse);
        StartCoroutine(ForceRock());
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            //other.gameObject.transform.SetParent(gameObject.transform.parent.transform , true);
            StopAllCoroutines();
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            //other.gameObject.transform.SetParent(gameObject.transform.parent.transform , true);        
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            StartCoroutine(ForceRock());
        }
    }
    
}
