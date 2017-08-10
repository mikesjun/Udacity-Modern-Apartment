using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoursHand : MonoBehaviour {

	float speed = 10f;

	void Update ()
	{
		transform.Rotate(Vector2.up,speed * Time.deltaTime);
	}
}