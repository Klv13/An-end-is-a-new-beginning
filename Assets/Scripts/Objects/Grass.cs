using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{

    public gameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.ToString() == "Player" && Input.GetKey(KeyCode.LeftControl))
        {
            gameManager.ResetLevel();
        }
    }
}
