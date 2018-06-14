using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using UnityEngine;

public class Camera_Model : MonoBehaviour
{

	//Zooming camera in
	public double x, y, z;

	public Transform Target;
	public Vector3 RelativePosition;
	public Rigidbody rb;

	public double Y
	{
		//Value y gives when its called
		get { return y; }
		//y = Value
		set { y = -0.5; }
	}

	public double Z
	{
		get { return z; }
		set { z = 1.5; }
	}

	public bool IsFirstPersonMode;


	void Start()
	{
		rb = GetComponent<Rigidbody>();
		RelativePosition = transform.position - Target.position;
	}

	// Update is called once per frame
	void Update()
	{
		//transform.position = Target.position + RelativePosition;

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
