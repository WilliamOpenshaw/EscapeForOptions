using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class DriveShip : MonoBehaviour
{
    public GameObject playerChar;
    public GameObject EnterVehicleMessage;
    public bool driving;
    public Rigidbody shipBody;
    Vector3 turnVelocity;
    Vector3 negTurnVelocity;
    float timeNow;
    void Start()
    {
        driving = false;
        shipBody = gameObject.GetComponent<Rigidbody>();
        turnVelocity = new Vector3(0, 0, 100);
        negTurnVelocity = new Vector3(0, 0, -100);
        EnterVehicleMessage.SetActive(false);
    }
    void FixedUpdate()
    {
        if (driving == true)
        {
            Quaternion deltaRotation = Quaternion.Euler(turnVelocity * Time.deltaTime);
            Quaternion negDeltaRotation = Quaternion.Euler(negTurnVelocity * Time.deltaTime);
            if (Input.GetKey(KeyCode.W))
            {
                shipBody.AddForce(gameObject.transform.up * -5000f, ForceMode.Force);
            }
            if (Input.GetKey(KeyCode.A))
            {
                shipBody.MoveRotation(shipBody.rotation * negDeltaRotation);
            }
            if (Input.GetKey(KeyCode.D))
            {
                shipBody.MoveRotation(shipBody.rotation * deltaRotation);
            }
            if (Input.GetKey(KeyCode.S))
            {
                shipBody.AddForce(gameObject.transform.up * 5000f, ForceMode.Force);
            }
            if (Input.GetKey(KeyCode.Z))
            {
                shipBody.AddForce(gameObject.transform.forward * -500f, ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.C))
            {
                shipBody.AddForce(gameObject.transform.forward * 500f, ForceMode.Acceleration);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                gameObject.GetComponent<MoveRock>().enabled = true;
                driving = false;
                //StartCoroutine(SetDrivingFalse());
                playerChar.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed = 10;
                playerChar.GetComponent<RigidbodyFirstPersonController>().movementSettings.BackwardSpeed = 10;
                playerChar.GetComponent<RigidbodyFirstPersonController>().movementSettings.StrafeSpeed = 10;
                playerChar.gameObject.transform.SetParent(null);
                playerChar.GetComponent<Rigidbody>().useGravity = true;  
                playerChar.GetComponent<CapsuleCollider>().enabled = true;
                timeNow = Time.time;  
                EnterVehicleMessage.SetActive(true);            
            }
            playerChar.transform.localPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.2f, gameObject.transform.position.z);
        }
    }
    void OnTriggerStay (Collider other)
     {
         if (other.gameObject.tag == "Player")
        { 
            if(Input.GetKeyDown(KeyCode.E) && driving == false && Time.time > timeNow + 1)
            {               
                gameObject.GetComponent<MoveRock>().enabled = false;
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
                driving = true;
                //other.gameObject.transform.rotation = Quaternion.Euler(90, 0, 0);
                other.GetComponent<RigidbodyFirstPersonController>().enabled = false;
                
                //other.gameObject.transform.rotation = Quaternion.Euler(90, 0, 0);
                                
                other.GetComponent<Rigidbody>().useGravity = false;                
                //other.gameObject.transform.SetParent(gameObject.transform, true); 
                other.GetComponent<CapsuleCollider>().enabled = false;         
                
                other.GetComponent<RigidbodyFirstPersonController>().enabled = true;
                other.GetComponent<RigidbodyFirstPersonController>().movementSettings.ForwardSpeed = 0;
                other.GetComponent<RigidbodyFirstPersonController>().movementSettings.BackwardSpeed = 0;
                other.GetComponent<RigidbodyFirstPersonController>().movementSettings.StrafeSpeed = 0;
                //other.GetComponent<RigidbodyFirstPersonController>().mouseLook.clampVerticalRotation = false; 
                EnterVehicleMessage.SetActive(false);               
            } 
        }
     } 
     void OnTriggerEnter (Collider other)
     {
         if (other.gameObject.tag == "Player")
         {
             EnterVehicleMessage.SetActive(true);
         }
         
     }
     void OnTriggerExit (Collider other)
     {
         if (other.gameObject.tag == "Player")
         {
            EnterVehicleMessage.SetActive(false);    
         }
         
     }       
}
