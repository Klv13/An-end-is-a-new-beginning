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
            gameManager.ResetLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.ToString() == "Toaster")
        {
            
            Hastoster = true;
        }

        if (other.tag.ToString() == "Player")
        {
            
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
