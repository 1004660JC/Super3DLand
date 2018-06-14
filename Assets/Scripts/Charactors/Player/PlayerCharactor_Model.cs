using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharactor_Model : BaseCharactor_Model
{
	public CharactorType MyCharactorType;
	public DamagePlayer Dp;
	public Movement_Model MovementModel;
	public Movement_View MovementView;
	void OnEnable()
	{
		Dp.OnPlayerHit += Lowerhealth;
	}

	void OnDisable()
	{
		Dp.OnPlayerHit -= Lowerhealth;
	}

	// Use this for initialization
	void Start()
	{
		MovementModel = GetComponent<Movement_Model>();
		MovementView = GetComponent<Movement_View>();
		CurrentHitPoints = SetVariable(StartHitPoints);
		CurrentManaPoints =	SetVariable(StartManaPoints);
		CurrentStaminaPoints = SetVariable(StartStaminaPoints);
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void Lowerhealth()
	{
		CurrentHitPoints = DecressVariable(CurrentHitPoints, DecressHitPoints);
	}
}
