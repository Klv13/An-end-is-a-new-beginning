using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandWich : MonoBehaviour
{

    public string tag = "poison";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == tag)
        {
            //Play Anim
            gameManager.ResetLevel();
        }
    }
}
