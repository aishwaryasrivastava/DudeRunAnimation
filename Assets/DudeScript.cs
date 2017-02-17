using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeScript : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		float forward_speed = Input.GetAxis ("Vertical");
		print (forward_speed);
		float direction = Input.GetAxis ("Horizontal");
		anim.SetFloat ("Speed", forward_speed);
		pos.z += forward_speed;
		anim.SetFloat ("Direction", direction, 0.25f,Time.deltaTime);
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			anim.SetTrigger("Die");
		}
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			anim.SetTrigger("Revive");
		}
		if(Input.GetKeyDown(KeyCode.Alpha3)){
			anim.SetTrigger("Wave");
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			anim.SetTrigger("Jump");
		}

	}


}
