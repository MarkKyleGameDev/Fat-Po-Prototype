using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teppanyaki : MonoBehaviour
{
    public GameObject grillObj0 = null;
    public GameObject grillObj1 = null;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && GameVariables.teapot)
        {
            Destroy(gameObject);
            //grillObj0.GetComponent<Renderer>().enabled = false;
            //grillObj0.GetComponent<Collider2D>().enabled = false;
            //grillObj1.GetComponent<Renderer>().enabled = true;
            grillObj1.GetComponent<Collider2D>().enabled = true;
            
        }
    }
}