using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackgroundClick : MonoBehaviour, IPointerDownHandler
{
    
	// Use this for initialization
	void Start () {
		
	}
	public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("hello");
        globals.mouse2 = eventData.position;
        globals.moveTo = globals.mouse2;
        globals.moveTo = globals.cam.ScreenToWorldPoint(globals.moveTo);
        Debug.Log(globals.moveTo);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
