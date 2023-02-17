using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
        List<int> CRumIndex = new List<int>();
        for (int i = 0; i < cornerRooms.Count; i++)
        {
            CRumIndex.Add(i);
        }

        shuffleList(CRumIndex);


        createRooms(cornerRooms, cornerPositions,CRumIndex);



        List<int> RumIndex = new List<int>();
        for (int i = 0; i < MiddleRooms.Count; i++)
        {
            RumIndex.Add(i);
        }

        shuffleList(RumIndex);


        createRooms(MiddleRooms, MiddlePositions, RumIndex);


       //Debug.Log("Generated Middle");
       //Instantiate(MiddleRooms[Rand], MiddlePositions[i].transform.position, MiddlePositions[i].transform.rotation);
    }

    void shuffleList<T>(List<T> inputList)
    {
        for (int i = 0; i < inputList.Count - 1; i++)
        {
            T temp = inputList[i];
            int rand = Random.Range(i, inputList.Count);
            inputList[i] = inputList[rand];
            inputList[rand] = temp;
        }
    }

    void createRooms(List<GameObject> rum, List<GameObject> RumPosition, List<int> Index)
    {
        for (int i = 0; i < RumPosition.Count; i++)
        {

            Instantiate(rum[Index[i]], RumPosition[i].transform.position, RumPosition[i].transform.rotation);
            Debug.Log("Generated Corner");

        }
    }

}
