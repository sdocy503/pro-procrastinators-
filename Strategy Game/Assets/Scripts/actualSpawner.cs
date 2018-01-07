using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class actualSpawner : MonoBehaviour {
    public Text timerText;
    public GameObject character;
    public static Vector3 spawnPoint;
    public GameObject building;
    // Use this for initialization
    void Start () {
		
	}
    public void callSpawnTimer()
    {
        StartCoroutine(spawnTime());
    }
    public void callClearText()
    {
        StartCoroutine(clearMainCharacterText());
    }
    public IEnumerator spawnTime()
    {
        int i;

        for (i = 5; i > 0; i--)
        {
            timerText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
        timerText.text = "";
        spawnPoint = building.transform.GetComponent<Transform>().position;
        spawnPoint.x += 6.0f;
        Debug.Log(spawnPoint);
        GameObject temp;

        temp = Instantiate(character, spawnPoint, Quaternion.identity) as GameObject;
    }
    public IEnumerator clearMainCharacterText()
    {
        timerText.text = "You already have this unit.";
        yield return new WaitForSeconds(3);
        timerText.text = "";
    }
    // Update is called once per frame
    void Update () {
		
	}
}
