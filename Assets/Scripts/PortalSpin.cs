using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpin : MonoBehaviour
{
    float forward;
    float up;
    float right;
    void Start()
    {
        forward = Random.Range(-10.0f, 10.0f);
        up = Random.Range(-10.0f, 10.0f);
        right = Random.Range(-10.0f, 10.0f);
        //gameObject.transform.localPosition = new Vector3(0, 0,  Random.Range(-0.10f, 0f));
        //gameObject.transform.localScale = new Vector3(Random.Range(0.2f, 2.0f), Random.Range(0.2f, 2.0f) , 0.002f);
        StartCoroutine(ChangePortalSpin());     
    }
       void Update()
    {
        gameObject.transform.Rotate(Vector3.forward * forward , Space.World);
        gameObject.transform.Rotate(Vector3.up * up , Space.World);
        gameObject.transform.Rotate(Vector3.right * right , Space.World);
    }
    public IEnumerator ChangePortalSpin()
    {
        //yield return new WaitForSeconds(Random.Range(10.0f, 3.0f));
        yield return new WaitForSeconds(3.0f);
        forward = Random.Range(-10.0f, 10.0f);
        up = Random.Range(-10.0f, 10.0f);
        right = Random.Range(-10.0f, 10.0f);  
        //gameObject.transform.localPosition = new Vector3(0, 0,  Random.Range(-0.10f, 0f));
        //gameObject.transform.localScale = new Vector3(Random.Range(0.2f, 10.0f), Random.Range(0.2f, 10.0f) , 0.002f);
        StartCoroutine(ChangePortalSpin());        
    }
}
