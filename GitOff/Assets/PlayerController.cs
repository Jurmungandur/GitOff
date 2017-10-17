using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed;
	public float acc;
	public float drag;
	private float speed;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetButton("Horizontal"))
		{
			if (speed < maxSpeed)
			{
				speed += acc;
			}
			else
			{
				speed = maxSpeed;
			}
		}
		else if (Input.GetButton("Vertical"))
		{
			if (speed < maxSpeed)
			{
				speed += acc;
			}
			else
			{
				speed = maxSpeed;
			}
		}
		else
		{
			speed *= drag;
		}
	}

	void FixedUpdate()
	{
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.fixedDeltaTime * speed);
	}
}
