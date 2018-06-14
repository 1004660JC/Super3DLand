using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
	public event Action OnPlayerHit;
	
	void OnTriggerEnter(Collider other)
	{
		
		PlayerCharactor_Model p = other.GetComponent<PlayerCharactor_Model>();
		if (p)
		{
			if (OnPlayerHit != null)
			{
				OnPlayerHit();
			}
			
		}
	}
}
