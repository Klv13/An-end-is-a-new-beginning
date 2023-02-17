using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    private float tid = 0;
    private TextMeshProUGUI TextMesh;
    public float multi = 1; 

    // Start is called before the first frame update
    void Start()
    {
        TextMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tid += Time.deltaTime *multi; 
        TextMesh.text = tid.ToString().Remove(tid.ToString().IndexOf(","));
        
        
    }
}
