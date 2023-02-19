using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lys : MonoBehaviour
{
    public string tag = "batteri";
    public gameManager gameManager;
    public GameObject ParicleSys;

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
            Explode();
            System.Threading.Thread.Sleep(200);
            gameManager.ResetLevel();
        }
    }

    void Explode()
    {
        Instantiate(ParicleSys, gameObject.transform.position, transform.rotation);
    }
}
