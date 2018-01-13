using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    const float speed = 1.0f;
    const float posCheckDelay = 0.5f;
    bool chill = false;
    Vector3 oldRally;
    // Use this for initialization
    void Start () {
        StartCoroutine(areWeThereYet());
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

        if (oldRally != globals.moveTo)
        {
            oldRally = globals.moveTo;
            chill = false;

        }
        if (chill)
        {
            return;
        }
        Debug.Log("I moved");
        if (x < moveToX)
        {
            //Debug.Log("Move Positive Horizontal");
            xdir = 1;
        }
        else if(x > moveToX)
        {
            //Debug.Log("Move Negative Horizontal");
            xdir = -1;
        }
        else if(x == moveToX)
        {
            //Debug.Log("Equal Horizontal");
            xdir = 0;
        }
        if(y < moveToY)
        {
            //Debug.Log("Move Positive Vertical");
            ydir = 1;
        }
        else if(y > moveToY)
        {
            //Debug.Log("Move Negative Vertical");
            ydir = -1;
        }
        else if(y == moveToY)
        {
            //Debug.Log("Equal Vertical");
            ydir = 0;
        }
        
        if (xdir != 0 || ydir != 0)
        {
            transform.Translate(Time.deltaTime * speed * xdir, Time.deltaTime * speed * ydir, 0);
            
        }
	}
    IEnumerator areWeThereYet()
    {
        Vector3 oldSpot = transform.position;
        Vector3 newSpot;
        float distanceX;
        float distanceY;
        float totalDistance;
        const int frameDelay = 10;
        int frames = frameDelay;

        Debug.Log("areWeThereYet Begins");
        while (true)
        {
            yield return new WaitForSeconds(Time.deltaTime * frameDelay);
            if (chill)
            {
                continue;
            }
            /*while (frames > 0)
            {
                yield return null;
                frames--;
            }*/
            newSpot = transform.position;
            distanceX = Mathf.Abs(oldSpot.x - newSpot.x);
            distanceY = Mathf.Abs(oldSpot.y - newSpot.y);
            Debug.Log("X = " + oldSpot.x + " " + newSpot.x);
            Debug.Log("Y = " + oldSpot.y + " " + newSpot.y);
            totalDistance = distanceX + distanceY;
            Debug.Log("TD = " +totalDistance);
            Debug.Log("FD = " +frameDelay / 2 * Time.deltaTime);
            if(totalDistance < frameDelay / 2 * Time.deltaTime)
            {
                chill = true;
                Debug.Log("Chill is True");
            }
            else
            {
                
                Debug.Log("Chill is False");
                oldSpot = transform.position;
            }
        }
    }
}
