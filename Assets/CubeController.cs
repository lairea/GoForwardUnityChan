using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	private float speed = -12;

	private float deadLine = -10;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		this.audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (this.speed * Time.deltaTime,0,0);
	
		if (this.transform.position.x < this.deadLine) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag") {
			audioSource.PlayOneShot(audioSource.clip);
		}             
	}
}
