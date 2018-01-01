using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour {

    public GameObject character;
    public static Vector3 spawnPoint;
    public GameObject building;
    //Vector3 buildingLocation;
    // Use this for initialization
    void Start () {
        
    }
	public void OnMouseDown()
    {
        //spawnPoint.x = 8.0f;
        //spawnPoint.y = 5.0f;
        //spawnPoint.z = 0.0f;
        spawnPoint = building.transform.GetComponent<Transform>().position;
        spawnPoint.x += 6.0f;
        Debug.Log(spawnPoint);
        GameObject temp;

        temp = Instantiate(character, spawnPoint, Quaternion.identity) as GameObject;
        //print("hi");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
