using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 4, 3, 6, 2, 1 };




		for (int a = 0; a < array.Length; a++) {
			Debug.Log (array [a]);

		}

		for (int b = 0; b < array.Length / 2; b++) {
			int t = array [b];
			array [b] = array [array.Length - b - 1];
			array [array.Length - b - 1] = t;
		}
		for (int c = 0; c < array.Length; c++) {
			Debug.Log (array [c]);
		}
		
			
			
	}		
			

							
			
	
			
		

		
		
	

	// Update is called once per frame
	void Update () {
		
	}
}
