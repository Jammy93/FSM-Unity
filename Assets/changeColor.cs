using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {
	public Color32 color32 = new Color32(64, 128, 192, 255);
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void Update ()
	{
		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Renderer> ().material.color = Color.black; 
		}

		if (Input.GetKey (KeyCode.S)) {
			GetComponent<Renderer> ().material.color = Color.blue; 
		}
		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Renderer> ().material.color = Color.red; 
		}
		if (Input.GetKey (KeyCode.F)) {
			GetComponent<Renderer> ().material.color = Color.green; 
		}
	}
}
			
