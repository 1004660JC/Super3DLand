using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharactor_Model : MonoBehaviour
{
	public int StartHitPoints;
	public int StartManaPoints;
	public int StartStaminaPoints;

	public int CurrentHitPoints;
	public int CurrentManaPoints;
	public int CurrentStaminaPoints;

	public int MaxHitPoints;
	public int MaxManaPoints;
	public int MaxStaminaPoints;

	public int DecressHitPoints;
	public int DecressManaPoints;
	public int DecressStaminaPoints;

	public enum CharactorType
	{
		PlayableCharactor,
		Non_PlayableCharactor
	}

	public virtual int SetVariable(int Start)
	{
		return Start;
	}

	public virtual bool CheckVariable(int Current, int CheckAmount)
	{
		return Current == CheckAmount;
	}

	public virtual int IncressVariable(int Current, int IncressPoints)
	{
		return Current - IncressPoints;
	}

	public virtual int DecressVariable(int Current, int DecressPoints)
	{
		return Current - DecressPoints;
	}


}
