using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 4, 3, 6, 2, 1 };
		int change1;
		int change2;
		int i;
		int t;
		int x;
		int y;


		for (i = 0; i < array.Length - 1; i++) {
			for (t = i + 1; t < array.Length; t++) {
				if (array [t] < array [i]) {
					change1 = array [t];
					array [t] = array [i];
					array [i] = change1;
				}			

			}
		}
		for (int a = 0; a < array.Length; a++) {
			Debug.Log (array [a]);
		}


			for (x = 0; x < array.Length - 1; x++) {
				for (y = x + 1; y < array.Length; y++) {
					if (array [y] > array [x]) {
						change2 = array [y];
						array [y] = array [x];
						array [x] = change2;
					}
				}
			}
			for (int b = 0; b < array.Length; b++) {
				Debug.Log (array [b]);
			}

	}
							
			
	
			
		

		
		
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
