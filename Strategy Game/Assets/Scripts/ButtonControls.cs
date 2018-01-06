using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControls : MonoBehaviour {
    const int maxButtons = 5;
    const int numBuildingsUnits = 2;
    const int maxOtherButtons = numBuildingsUnits * maxButtons - maxButtons;
    public GameObject[] myButtons = new GameObject[maxButtons];
    public GameObject[] otherButtons = new GameObject[maxOtherButtons];
    // Use this for initialization
	void Start () {
		
	}
    void OnMouseDown()
    {
        //Debug.Log("left click");
        int i;
        
        for (i = 0; i < maxOtherButtons; i++)
        {
            //Debug.Log(i);
            if (otherButtons[i] != null)
            {
                otherButtons[i].SetActive(false);
            }
        }
        for (i = 0; i < maxButtons; i++)
        {
            //Debug.Log(i);
            if (myButtons[i] != null)
            {
                myButtons[i].SetActive(true);
            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
