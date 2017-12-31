using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    const float speed = 0.5f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 currentPos = transform.position;
        int xdir = 0;
        int ydir = 0;
        float x = currentPos.x;
        float y = currentPos.y;
        float moveToX = globals.moveTo.x;
        float moveToY = globals.moveTo.y;
        if (x < moveToX)
        {
            Debug.Log("Move Positive Horizontal");
            xdir = 1;
        }
        else if(x > moveToX)
        {
            Debug.Log("Move Negative Horizontal");
            xdir = -1;
        }
        else if(x == moveToX)
        {
            Debug.Log("Equal Horizontal");
            xdir = 0;
        }
        if(y < moveToY)
        {
            Debug.Log("Move Positive Vertical");
            ydir = 1;
        }
        else if(y > moveToY)
        {
            Debug.Log("Move Negative Vertical");
            ydir = -1;
        }
        else if(y == moveToY)
        {
            Debug.Log("Equal Vertical");
            ydir = 0;
        }
        transform.Translate(Time.deltaTime * speed * xdir, Time.deltaTime * speed * ydir, 0);
	}
}
