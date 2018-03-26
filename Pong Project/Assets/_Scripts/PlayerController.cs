using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
	// Use this for initialization

	public bool isPlayer1;
	public bool isPlayer2;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (isPlayer1) 
		{
			GetComponent<Rigidbody> ().velocity = new Vector3(0,Input.GetAxis ("Player1Vertical") * speed*Time.deltaTime,0);
		}
		
		if (isPlayer2) 
		{
			GetComponent<Rigidbody> ().velocity = new Vector3(0,Input.GetAxis ("Player2Vertical") * speed*Time.deltaTime,0);
		}
	}

}
