using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using UnityEngine;

public class Camera_Model : MonoBehaviour
{

	//Zooming camera in
	public double x, y, z;

	public Transform LookAtTarget;
	public Vector3 CamPosition;
	public Rigidbody rb;

	public double Y
	{
		get { return y; }
		set { y = -0.5; }
	}

	public double Z
	{
		get { return z; }
		set { z = 1.5; }
	}

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		transform.LookAt(LookAtTarget);
		
		//zoom in and out
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.Translate(new Vector3(0, (float)y, (float)z));
		}

		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			transform.Translate(new Vector3(0,(float)-y, (float)-z));
		}

		//Rotate around object
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			if (rb != null)
			{
				//rb.AddForce();
			}
		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			
		}
	}
}
