using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Rigidbody rb;

	void Start () {
		
		rb = GetComponent<Rigidbody> ();
		StartCoroutine (Pause ());
	}

	void Update () {
		
		if (transform.position.x < -25f) {

			transform.position = Vector3.zero;
			rb.velocity = Vector3.zero;

			ScoreboardController.instance.GivePlayerTwoAPoint();
			StartCoroutine (Pause ());
		}

		if (transform.position.x > 25f) {

			transform.position = Vector3.zero;
			rb.velocity = Vector3.zero;

			ScoreboardController.instance.GivePlayerOneAPoint();
			StartCoroutine (Pause ());
		}
	}

	IEnumerator Pause () {
		
		yield return new WaitForSeconds (2.5f);
		LaunchBall ();
	}

	void LaunchBall () {

		transform.position = Vector3.zero;

		int xDirection = Random.Range(0, 2);

		int yDirection = Random.Range(0, 3);


		Vector3 launchDirection = new Vector3 ();

		if (xDirection == 0) 
		{
			launchDirection.x = -8f;
		}
		if (xDirection == 1) 
		{
			launchDirection.x = 8f;
		}
		if (yDirection == 0) 
		{
			launchDirection.y = -8f;
		}
		if (yDirection == 1) 
		{
			launchDirection.y = 8f;
		}
		if (yDirection == 2) 
		{
			launchDirection.y = 0f;
		}

		rb.velocity = launchDirection;
	}
	void OnCollisionEnter (Collision hit) {
		
		if (hit.gameObject.name == "TopBounds") {

			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 8f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -8f;

			rb.velocity = new Vector3 (speedInXDirection, -8f, 0f);
		}

		if (hit.gameObject.name == "BottomBounds") {
			
			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 8f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -8f;

			rb.velocity = new Vector3 (speedInXDirection, 8f, 0f);
		}

		if (hit.gameObject.name == "Left_Bat") {

			rb.velocity = new Vector3 (13f, 0f, 0f);
		
			if (transform.position.y - hit.gameObject.transform.position.y < -1) 
			{
				rb.velocity = new Vector3 (8f, -8f, 0f);
			}
			if (transform.position.y - hit.gameObject.transform.position.y > 1) {
				rb.velocity = new Vector3 (8f, 8f, 0f);
			}
		}
		if (hit.gameObject.name == "Right_Bat") {
			
			rb.velocity = new Vector3 (-13f, 0f, 0f);

			if (transform.position.y - hit.gameObject.transform.position.y < -1) 
			{
				rb.velocity = new Vector3 (-8f, -8f, 0f);
			}
			if (transform.position.y - hit.gameObject.transform.position.y > 1) {

				rb.velocity = new Vector3 (-8f, 8f, 0f);
			}
		}

	}

}
