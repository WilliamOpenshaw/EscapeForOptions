using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class punchForce : MonoBehaviour
{
    public int soundChoice;

    public AudioClip punch;

    public AudioClip punch2;

    public AudioClip punch3;

    public AudioClip punch4;

    public AudioClip punch5;

    public AudioClip punch6;

    public AudioSource copPunch;

    private Rigidbody rig;

    public GameObject cop;

    public GameObject camera1;

    public bool punchingAnimator0;

    public float time0;

    private Animator copAnim;

    public GameObject paidLeaveNum;

    public GameObject damagesNum;

    public bool coroutineRunning;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;

        copAnim = cop.GetComponent<Animator>();

        punchingAnimator0 = false;

        rig = GetComponent<Rigidbody>();

        coroutineRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        time0 = copAnim.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }

    void OnTriggerStay(Collider other)
    {
        if (copAnim.GetBool("isPunching") && other.tag == "Cop")
        {
            punchingAnimator0 = true;
            Vector3 dir = other.transform.position - transform.position;

            dir = -dir.normalized;

            if (coroutineRunning == false)
            {
                StartCoroutine(forcePunchWait(dir));
            }
        }
    }

    private IEnumerator forcePunchWait(Vector3 direction)
    {
        coroutineRunning = true;

        yield return new WaitForSeconds(0.45f);

        PlayPunchSound();

        rig.AddForce(direction * 100.0f, ForceMode.Impulse);
        rig.AddForce(Vector3.up * 75.0f, ForceMode.Impulse);
        rig.AddForce(camera1.transform.forward * 150.0f, ForceMode.Impulse);
        rig.AddForce(camera1.transform.up * 75.0f, ForceMode.Impulse);

        LeaveandDamages();

        coroutineRunning = false;
    }

    public void LeaveandDamages()
    {
        paidLeaveNum.GetComponent<Text>().text =
            (
            int.Parse(paidLeaveNum.GetComponent<Text>().text) +
            (Random.Range(1, 3))
            ).ToString();
        damagesNum.GetComponent<Text>().text =
            (
            int.Parse(damagesNum.GetComponent<Text>().text) +
            (Random.Range(10, 50) * Random.Range(1000, 10000))
            ).ToString();
    }

    public void PlayPunchSound()
    {
        soundChoice = Random.Range(1, 7);

        copPunch.pitch = Random.Range(0.5f, 1.5f);

        switch (soundChoice)
        {
            case 1:
                copPunch.PlayOneShot(punch, 1.0f);
                break;
            case 2:
                copPunch.PlayOneShot(punch2, 1.0f);
                break;
            case 3:
                copPunch.PlayOneShot(punch3, 1.0f);
                break;
            case 4:
                copPunch.PlayOneShot(punch4, 1.0f);
                break;
            case 5:
                copPunch.PlayOneShot(punch5, 1.0f);
                break;
            case 6:
                copPunch.PlayOneShot(punch6, 1.0f);
                break;
        }

        copPunch.PlayOneShot(punch, 1.0f);
    }

    
}
