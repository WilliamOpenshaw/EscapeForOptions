using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunTurn : MonoBehaviour
{       
    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward * 0.1f , Space.World);
    }
}
