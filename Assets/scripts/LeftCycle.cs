using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCycle : MonoBehaviour {

		public float moveSpeed = 5f;
		public float leftWayPointX = 8f, rightWayPointX = 8f;

		// Update is called once per frame
		void Update () {
			transform.position = new Vector2 (transform.position.x + moveSpeed * Time.deltaTime,
				transform.position.y);

			if (transform.position.x < leftWayPointX)
			transform.position = new Vector2 (rightWayPointX, transform.position.y);
		}
	}
