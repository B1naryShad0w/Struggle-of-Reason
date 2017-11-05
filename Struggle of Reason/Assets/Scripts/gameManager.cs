using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public float energy = 100f;
    public float happiness = 100f;

    public int visitRatio = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Random.Range(0, 100) < visitRatio) { goodSpawn(); }
        else { badSpawn(); }
    }

    void missedVisit()
    {
        visitRatio -= 5;

        Debug.Log("You Missed a Visit!");
    }

    void goodSpawn()
    {
        Debug.Log("Spawning Good Character");
    }
    
    void badSpawn()
    {
        Debug.Log("Spawning Bad Character");
    }
}
