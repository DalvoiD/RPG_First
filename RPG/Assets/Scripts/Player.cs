using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public int MaxHealth; // Максимальное количество здоровья
	public int CurHealth; // Текущее количество здоровья
	public int MaxMana; // Максимально количество маны
	public int CurMana; // Текущее количество маны

	void Start()
	{

	}

	void Update()
	{
		if (MaxHealth < CurHealth) CurHealth = MaxHealth;
		if (MaxMana < CurMana) CurMana = MaxMana;
	}
}
