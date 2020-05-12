using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player" && GameVariables.ingredients >= 3) {
			GameVariables.ingredients = 0;
			Destroy (gameObject);          
		}
	}
}
