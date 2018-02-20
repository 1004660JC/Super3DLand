using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharactor_Model : MonoBehaviour
{
	private int StartHitPoints;
	private int CurrentHitPoints;
	private int MaxHitPoints;
	private int DecressHitPoints;

	private int StartManaPoints;
	private int CurrentManaPoints;
	private int MaxManaPoints;
	private int DecressManaPoints;

	private int StartStaminaPoints;
	private int CurrentStaminaPoints;
	private int MaxStaminaPoints;
	private int DecressStaminaPoints;

	public enum CharactorType
	{
		PlayableCharactor,
		Non_PlayableCharactor
	}

	public virtual void SetVariable(int Start, int Current)
	{
		Current = Start;
	}

	public virtual bool CheckVariable(int Current, int CheckAmount)
	{
		return Current == CheckAmount;
	}

	public virtual int DecressVariable(int Current, int DecressPoints)
	{
		return Current = Current - DecressPoints;
	}


}
