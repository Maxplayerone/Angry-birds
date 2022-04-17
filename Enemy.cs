using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	//TODO: make particle effect
	public GameObject deathEffect;
	public float health = 4f;
	public static int EnemiesAlive = 0;

	void Start()
	{
		EnemiesAlive++;
	}

	void OnCollisionEnter2D(Collision2D colInfo)
	{
		//damage from height
		if (colInfo.relativeVelocity.magnitude > health)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);

		EnemiesAlive--;
		if (EnemiesAlive <= 0)
			Debug.Log("LEVEL WON!");

		Destroy(gameObject);
	}

}
