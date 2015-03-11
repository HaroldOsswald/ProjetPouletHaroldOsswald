using UnityEngine;
using System.Collections;

public class changementPositionCamera : MonoBehaviour {

	public Vector3 targetPosition;
	public float targetFOV;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}


	void OnTriggerEnter(Collider col)
	{ 

		if (col.transform.gameObject.tag == "Player") {
			Camera.main.GetComponent<cameraPosition>().targetPosition = targetPosition;
			Camera.main.GetComponent<cameraPosition>().targetFieldOfView = targetFOV;
		}
	}

}

