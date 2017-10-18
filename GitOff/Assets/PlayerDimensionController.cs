using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDimensionController : MonoBehaviour {

    public int dimension = 0;
    private int maxDimension = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Space"))
        {
            if (dimension < maxDimension)
            {
                transform.Translate(new Vector3(0, 100, 0));
                dimension += 1;
            }
        }
        if (Input.GetButtonDown("Shift"))
        {
            if (dimension > -maxDimension)
            {
                transform.Translate(new Vector3(0, -100, 0));
                dimension -= 1;
            }
        }
    }
}
