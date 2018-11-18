using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBox : MonoBehaviour {

    public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;
    public int laneNum = 2;
    public string controllocked = "n";

	// Use this for initialization
	void Start () {
		// this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 30f,  ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
    }

}
