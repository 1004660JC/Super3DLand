using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Model : MonoBehaviour
{
	public String AxisNameH;
	public String AxisNameV;

	public float AxisInputH;
	public float AxisInputV;




	// Use this for initialization
	void Start()
	{
		AxisNameH = "H";
		AxisNameV = "V";
	}

	// Update is called once per frame
	void Update()
	{
		AxisInputH = Input.GetAxis(AxisNameH);
		AxisInputV = Input.GetAxis(AxisNameV);
	}
}
