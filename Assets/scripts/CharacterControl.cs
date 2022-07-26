using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CharacterControl : MonoBehaviour {

	Animator anim;
	Rigidbody2D rb;
	public float jumpForce = 700f;
	public float upOrDown;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.gameStopped != true) {
			upOrDown = CrossPlatformInputManager.GetAxisRaw ("Vertical");
			if (upOrDown > 0 && rb.velocity.y == 0)
				rb.AddForce (Vector2.up * jumpForce);

			if (upOrDown < 0 && rb.velocity.y == 0)
				anim.SetBool ("isDown", false);
			else
				anim.SetBool ("isDown", true);
		}
	}
}
