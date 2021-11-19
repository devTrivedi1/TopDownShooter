using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
	GameObject[] enemies;
	[SerializeField] TextMeshProUGUI enemyCount;
	[SerializeField] private GameObject completeLevelUI;

	void Start()
	{

	}
	void Update()
	{
		enemies = GameObject.FindGameObjectsWithTag("Enemies");
		enemyCount.text = "Enemies : " + enemies.Length.ToString();
		if(enemies.Length == 0)
		{
			CompleteLevel();
		}
	}


	void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}
}
