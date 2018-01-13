using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour {
    public bool isMainCharacter;
    public actualSpawner mySpawner;
    public static GameObject building;
    public GameObject buildingEditor;

    bool oneSpawn = false;
    //Vector3 buildingLocation;
    // Use this for initialization
    void Start () {
        building = buildingEditor;
    }
	public void OnMouseDown()
    {
        //spawnPoint.x = 8.0f;
        //spawnPoint.y = 5.0f;
        //spawnPoint.z = 0.0f;
        if(isMainCharacter == false)
        {
            //StartCoroutine(mySpawner.spawnTime());
            mySpawner.callSpawnTimer();
        }
        else if(isMainCharacter == true)
        {
            if(oneSpawn == false)
            {
                oneSpawn = true;
                //StartCoroutine(mySpawner.spawnTime());
                mySpawner.callSpawnTimer();
            }
            else if(oneSpawn == true)
            {

                //StartCoroutine(mySpawner.clearMainCharacterText());
                mySpawner.callClearText();
            }
        }

        //print("hi");
    }


    // Update is called once per frame
    void Update () {
		
	}
}
