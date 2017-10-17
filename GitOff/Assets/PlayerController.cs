using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed;
	public float acc;
	public float drag;
	private float speed;

    Camera viewCamera;

	void Start () {
        viewCamera = Camera.main;
	}
	
	void Update () {
        //Get player input
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

        //Make the player look at the cursor
        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float RayDistance;

        if (groundPlane.Raycast(ray, out RayDistance))
        {
            Vector3 point = ray.GetPoint(RayDistance);
            Vector3 lookPoint = new Vector3(point.x, transform.position.y, point.z);
            transform.LookAt(lookPoint);
        }
	}

	void FixedUpdate()
	{
        //Move the player
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.fixedDeltaTime * speed, Space.World);
	}
}
