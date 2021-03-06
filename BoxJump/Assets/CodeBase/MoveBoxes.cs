﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxes : MonoBehaviour {

	public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;
    public int laneNum = 2;
    public string controllocked = "n";

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GM.verticalVelocity, GM.horizontalVelocity);

        if(Input.GetKeyDown(moveL) && laneNum > 1 && controllocked == "n")
        {
            horizVel = -3;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controllocked = "y";
        }

        if (Input.GetKeyDown(moveR) && (laneNum < 3) && (controllocked == "n"))
        {
            horizVel = 3;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controllocked = "y";
        }
    }

	
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controllocked = "n";
    }

}
