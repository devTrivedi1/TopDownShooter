using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
	GameObject[] enemies;
	[SerializeField]TextMeshProUGUI enemyCount;

	void Start()
	{

	}
	void Update()
	{
		enemies = GameObject.FindGameObjectsWithTag("Enemies");
		enemyCount.text = "Enemies : " + enemies.Length.ToString();
	}
}
