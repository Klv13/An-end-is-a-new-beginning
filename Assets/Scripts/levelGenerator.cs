using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{

    public List<GameObject> cornerPositions = new List<GameObject>();
    public List<GameObject> cornerRooms = new List<GameObject>();
    public List<GameObject> MiddlePositions = new List<GameObject>();
    public List<GameObject> MiddleRooms = new List<GameObject>();
    public List<GameObject> CenterPostition = new List<GameObject>();
    public List<GameObject> CenterRooms = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cornerPositions.Count; i++)
        {
            Instantiate(cornerRooms[Random.Range(0, cornerRooms.Count)], cornerPositions[i].transform.position, cornerPositions[i].transform.rotation);
        }
    }

}
