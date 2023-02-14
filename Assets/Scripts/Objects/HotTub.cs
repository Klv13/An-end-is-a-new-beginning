using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotTub : MonoBehaviour
{

    bool Hastoster;
    bool PlayerIn;

    // Update is called once per frame
    void Update()
    {

        //Will Reset if True
        if(PlayerIn && Hastoster)
        {
            Debug.Log("reset");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.ToString() == "Toaster")
        {
            Debug.Log("Toaster IND");
            Hastoster = true;
        }

        if (other.tag.ToString() == "Player")
        {
            Debug.Log("Toaster IND");
            PlayerIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.ToString() == "Toaster")
        {
            
            Hastoster = false;
        }

        if (other.tag.ToString() == "Player")
        {
            
            PlayerIn = false;
        }
    }
}
