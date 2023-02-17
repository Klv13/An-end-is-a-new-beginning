using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.ToString() == "Player" && Input.GetKey(KeyCode.LeftControl))
        {
            gameManager.ResetLevel();
        }
    }
}
