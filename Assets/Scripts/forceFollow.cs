using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceFollow : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    
    public int targetNumber = 1;
    public bool miningResources;
    public float forwardVelocity;
    public float rightVelocity;
    public float upwardVelocity;
    public float teamPoints;
    //public float distanceMultiplier;
    public string shipVelocity;
    public Rigidbody rb;
    //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        miningResources = true;
        forwardVelocity = 0.001f;
        rightVelocity = 0.0001f;
        upwardVelocity = 0.00005f;
        //rightVelocity = 0.0f;
        //upwardVelocity = 0.0f;
        teamPoints = 1.0f;
        rb = GetComponent<Rigidbody>();
        targetNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (miningResources == true)
        {
            if(targetNumber == 1)
            {
                transform.LookAt(target1);
            }
            else if (targetNumber == 2)
            {
                transform.LookAt(target2);
            }
                             
        }
        
    }
    void FixedUpdate()
    {
        if (miningResources == true)
        {
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(teamPoints * rightVelocity, teamPoints * upwardVelocity, teamPoints * forwardVelocity, ForceMode.Impulse);
            //distanceMultiplier = Vector3.Distance(target.position, transform.position);
            
            //rb.drag = 30 * (1 / Vector3.Distance(target.position, transform.position));
            shipVelocity = rb.velocity.ToString();

            //rb.drag = 50 * (teamPoints * forwardVelocity) * (1 / Vector3.Distance(target.position, transform.position));
            if (targetNumber == 1)
            {
                rb.drag =  60 * (teamPoints * forwardVelocity) * (1 / Vector3.Distance(target1.position, transform.position));
            }
            else if (targetNumber == 2)
            {
                rb.drag = 60 * (teamPoints * forwardVelocity) * (1 / Vector3.Distance(target2.position, transform.position));
            }
            
        }
    }
}
