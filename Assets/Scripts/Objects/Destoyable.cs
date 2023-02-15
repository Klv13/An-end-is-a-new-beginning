using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyable : MonoBehaviour
{

    public GameObject DestroyedVersion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.ToString() == "Player")
        {
            Debug.Log("Dør");
            DestroyedVersion.SetActive(true);
            Destroy(gameObject);
            
        }
    }
}
