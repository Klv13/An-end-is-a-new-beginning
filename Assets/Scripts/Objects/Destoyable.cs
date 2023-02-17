using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyable : MonoBehaviour
{

    public GameObject DestroyedVersion;
    public string tag = "Player";
    public GameObject Needs;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.ToString() == tag)
        {
            Debug.Log("Dør");
            DestroyedVersion.SetActive(true);
            Destroy(gameObject);
            
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag.ToString() == tag)
        {
            Debug.Log("Dør");
            DestroyedVersion.SetActive(true);
            Destroy(gameObject);

        }
        else
        {
            Needs.active = true;
        }

    }
}
