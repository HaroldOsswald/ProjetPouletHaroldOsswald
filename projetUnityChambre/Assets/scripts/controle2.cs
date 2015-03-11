using UnityEngine;
using System.Collections;

public class controle2 : MonoBehaviour {

	public float speed = 5f;
	public float maxspeed;
	public float jumpspeed;
	private bool jumping = false;
	
	
	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Jumpable")
			jumping = false;
	}
	
	void FixedUpdate() {

		Vector3 velocity = new Vector3 (-Input.GetAxis ("Horizontal"),0 , -Input.GetAxis ("Vertical")).normalized * speed;
		velocity.y = rigidbody.velocity.y;
		rigidbody.velocity = velocity;
		velocity.y = 0;
		transform.LookAt (transform.position - velocity);

		if (Input.GetButtonDown ("Jump") && !jumping) {
			//transform.position += new Vector3 (0.0f, 100 * Time.deltaTime, 0.0f);
			rigidbody.AddForce (new Vector3 (0f, jumpspeed, 0f), ForceMode.Impulse);
			jumping = true;
		}




		/*
		if(Input.GetAxis("Horizontal") > 0.2)
		if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log (Camera.main.transform.right);
			transform.LookAt (transform.position - Camera.main.transform.right);
			if (Mathf.Abs (rigidbody.velocity.x) < maxspeed){
				rigidbody.velocity -= new Vector3 (
					speed += Input.GetAxis("Horizontal"), 0.0f, 0.0f);
			}
		}
		if (Input.GetKeyUp (KeyCode.RightArrow))
			speed = 1f;
		if (Input.GetKey (KeyCode.LeftArrow)) {
						rigidbody.velocity += new Vector3 (++ speed, 0.0f, 0.0f);
			transform.LookAt (transform.position + Camera.main.transform.right);
				}
		else if (speed > maxspeed)
			speed = maxspeed;
		if (Input.GetKeyUp (KeyCode.LeftArrow))
			speed = 1f;
		if (Input.GetKey (KeyCode.UpArrow)){
			rigidbody.velocity -= new Vector3 (0.0f, 0.0f,++ speed);
			transform.LookAt (Vector3.forward);
		}
		else if (speed > maxspeed)
			speed = maxspeed;
		if (Input.GetKeyUp (KeyCode.UpArrow))
			speed = 1f;
		if (Input.GetKey (KeyCode.DownArrow)){
			rigidbody.velocity += new Vector3 (0.0f, 0.0f,++ speed);
			transform.LookAt (Vector3.back);
		}
		else if (speed > maxspeed)
			speed = maxspeed;
		if (Input.GetKeyUp (KeyCode.DownArrow))
			speed = 1f;
		Debug.Log (rigidbody.velocity.y);
		*/
	}
}