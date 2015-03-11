using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class impactson : MonoBehaviour {

	private AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnCollisionEnter(Collision collision)
	{ 
		//float force = collision.relativeVelocity
			if(!audioSrc.isPlaying)
			//audioSrc.volume = ForceMode / 50;
		    audioSrc.Play();
}
}