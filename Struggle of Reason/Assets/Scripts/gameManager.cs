using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {
    public Slider happinessSlider;
    public Slider energySlider;

    public int happiness = 100;
    public int energy = 100;
    
    public int visitRatio = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        energySlider.value = energy;
        happinessSlider.value = happiness;
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
