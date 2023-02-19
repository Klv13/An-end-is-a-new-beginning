using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class script : MonoBehaviour
{

    public string tag = "poison";
    public gameManager gameManager;
    public VideoPlayer player;
    public float TimeToDie = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            player.Play();
            Invoke("die", 2f);


        }
    }

    public void die()
    {
        gameManager.ResetLevel();
    }
}
