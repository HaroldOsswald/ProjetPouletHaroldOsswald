using UnityEngine;
using System.Collections;

public class cameraPosition : MonoBehaviour {

	public Vector3 targetPosition;
	private Vector3 Velocity = Vector3.zero;
	public float time;
	public float targetFieldOfView;
	private float FOVVelocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (targetPosition != transform.position) {
			transform.position = new Vector3 (Mathf.SmoothDamp (transform.position.x, targetPosition.x, ref Velocity.x, time),
		                                 Mathf.SmoothDamp (transform.position.y, targetPosition.y, ref Velocity.y, time),
		                                 Mathf.SmoothDamp (transform.position.z, targetPosition.z, ref Velocity.z, time));
		}
		if (targetFieldOfView != transform.gameObject.GetComponent<Camera> ().fieldOfView) {
			transform.gameObject.GetComponent<Camera> ().fieldOfView = Mathf.SmoothDamp (transform.gameObject.GetComponent<Camera> ().fieldOfView, targetFieldOfView, ref FOVVelocity, time);
		}
	}
}
