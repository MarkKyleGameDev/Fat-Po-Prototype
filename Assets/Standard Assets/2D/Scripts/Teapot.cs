using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teapot : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameVariables.teapot = true;
            Destroy(gameObject);
        }
    }
}