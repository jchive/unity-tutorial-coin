using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		var position = transform.localPosition;

		position.x += Mathf.Clamp(Input.GetAxisRaw("Horizontal"), -0.1f, 0.1f);

		if (position.x < -3)
			position.x = -3;

		if (position.x > 2)
			position.x = 2;

		transform.localPosition = position;
	}
}
