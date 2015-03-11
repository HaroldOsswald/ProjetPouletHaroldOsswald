using UnityEngine;
using System.Collections;

public class controlepoulet : MonoBehaviour {
	
	public float speed;
	public float maxspeed;
	public float jumpspeed;

	
	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate() {
		if (Input.GetKey (KeyCode.RightArrow))
				transform.position -= new Vector3 (++ speed * Time.deltaTime, 0.0f, 0.0f);
		else if (speed > maxspeed)
				speed = maxspeed;
		if (Input.GetKeyUp (KeyCode.RightArrow))
				speed = 1f;
		if (Input.GetKey (KeyCode.LeftArrow))
				transform.position += new Vector3 (++ speed * Time.deltaTime, 0.0f, 0.0f);
		else if (speed > maxspeed)
				speed = maxspeed;
		if (Input.GetKeyUp (KeyCode.LeftArrow))
				speed = 1f;
		if (Input.GetKey (KeyCode.UpArrow))
			transform.position -= new Vector3 (0.0f, 0.0f,++ speed * Time.deltaTime);
		else if (speed > maxspeed)
			speed = maxspeed;
		if (Input.GetKeyUp (KeyCode.UpArrow))
			speed = 1f;
		if (Input.GetKey (KeyCode.DownArrow))
			transform.position += new Vector3 (0.0f, 0.0f,++ speed * Time.deltaTime);
		else if (speed > maxspeed)
			speed = maxspeed;
		if (Input.GetKeyUp (KeyCode.DownArrow))
			speed = 1f;
		Debug.Log (rigidbody.velocity.y);
		if (Input.GetKey (KeyCode.Space) && rigidbody.velocity.y == 0f) {
				//transform.position += new Vector3 (0.0f, 100 * Time.deltaTime, 0.0f);
			rigidbody.AddForce (new Vector3 (0f, jumpspeed, 0f), ForceMode.Impulse);
		}
	}
}