using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour {

	public GameObject leftBat;
	public GameObject rightBat;

	void Update () {

		leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

		if (Input.GetKey (KeyCode.W)) {
			
			leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 8f, 0f);
		}
		else if (Input.GetKey (KeyCode.S)) 
		{
				leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -8f, 0f);
		}
				rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

		if (Input.GetKey (KeyCode.UpArrow)) {
				rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 8f, 0f);
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
				rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -8f, 0f);
		}
	}
}
