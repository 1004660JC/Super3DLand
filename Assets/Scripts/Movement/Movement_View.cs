using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_View : MonoBehaviour
{

	public Movement_Model MM;
	public int Speed;

	void OnEnable()
	{
		MM = GetComponent<Movement_Model>();
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(MM.AxisInputH * Speed, 0, MM.AxisInputV * Speed);
	}
}
