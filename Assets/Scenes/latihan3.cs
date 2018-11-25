using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latihan3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		   int c = Jumlah(60, 40);
                Debug.Log("Hasil Jumlah a dan b adalah " + c);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	    int Jumlah(int a, int b)
        {
            return a + b;
        }
}
