using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int [] points = {30, 20, 50, 10, 80, 15, 60, 100};

		for(int i = 0; i < points.Length; i++){
			if(points[i] >= 50){
				Debug.Log(points[i]);
			}
		}
			
	

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
