using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globals : MonoBehaviour {
    public static Vector2 mouse2;
    public static Vector3 moveTo;
    public static Camera cam;
    public static bool newRallyPoint = false;
    public AudioSource myPlayer;
    public AudioClip gameTrack;

    // Use this for initialization
    void Start () {
        cam = Camera.main;
        moveTo = actualSpawner.spawnPoint;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
