using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkAnim : MonoBehaviour
{
    private Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        Debug.Log("Anim " + anim);
    }

    public void PlayAnimation()
    {

        anim.playAutomatically = true;
        anim.enabled = true;

        
    }

   

}
