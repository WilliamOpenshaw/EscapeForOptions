using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.localPosition = new Vector3(Random.Range(-80.0f, 100.0f), Random.Range(-20.0f, 50.0f), Random.Range(-80.0f, 100.0f));
        StartCoroutine("ChangePositionAndDirection", Random.Range(0.5f, 1.0f));
        StartCoroutine("ChangeNumber", Random.Range(0.1f, 0.5f));
    }

    // Update is called once per frame
    
    void OnEnable()
    {
        gameObject.transform.localPosition = new Vector3(Random.Range(-80.0f, 100.0f), Random.Range(-20.0f, 50.0f), Random.Range(-80.0f, 100.0f));
        StartCoroutine("ChangePositionAndDirection", Random.Range(0.5f, 1.0f));
        StartCoroutine("ChangeNumber", Random.Range(0.1f, 0.5f));
    }
    private IEnumerator ChangePositionAndDirection(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.transform.localPosition = new Vector3(Random.Range(-80.0f, 100.0f), Random.Range(-20.0f, 50.0f), Random.Range(-80.0f, 100.0f));
        gameObject.transform.localRotation = Quaternion.Euler(0, Random.Range(-180.0f, 180.0f), 0);
        gameObject.transform.localScale = new Vector3(Random.Range(0.1f, 1.0f), Random.Range(0.1f, 1.0f), Random.Range(0.1f, 1.0f));
        gameObject.GetComponent<Rigidbody>().AddForce(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f), ForceMode.Impulse);
        StartCoroutine("ChangePositionAndDirection", Random.Range(0.5f, 1.0f));
    }

    private IEnumerator ChangeNumber(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.GetComponent<TMPro.TextMeshPro>().text = Random.Range(1, 100).ToString();
        StartCoroutine("ChangeNumber", Random.Range(0.1f, 0.5f));
    }
}
