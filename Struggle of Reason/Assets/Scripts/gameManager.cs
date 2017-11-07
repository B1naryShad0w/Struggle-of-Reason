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
    public float energyReductionRate = 1f;

    [HideInInspector]
    public bool curMoveState = false;
    private bool prevMoveState = false;
    private float passedTime;
    
	void Start () {
		
	}
	
	void Update () {
        if (curMoveState == true)
        {
            prevMoveState = true;
            passedTime += Time.deltaTime * energyReductionRate;

            if (passedTime >= 1)
            {
                energy -= (int)(Mathf.Floor(passedTime));
                passedTime -= Mathf.Floor(passedTime);
            }
        }

        if (curMoveState == false && prevMoveState == true)
        {
            energy -= Mathf.RoundToInt(passedTime);
            prevMoveState = false;
        }


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
