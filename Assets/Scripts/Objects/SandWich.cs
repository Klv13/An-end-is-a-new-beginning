using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandWich : MonoBehaviour
{

    public string tag = "poison";
    public gameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == tag)
        {
            //Play Anim
            gameManager.ResetLevel();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            gameManager.ResetLevel();
        }
    }
}
