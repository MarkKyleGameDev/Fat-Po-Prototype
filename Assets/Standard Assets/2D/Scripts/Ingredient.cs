using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ingredient : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			GameVariables.ingredients++;
			Destroy (gameObject);
            //print(GameVariables.ingredients);
            GameVariables.checkpoint = col.transform.position;
            //OnGui();
        }       
	}

}
