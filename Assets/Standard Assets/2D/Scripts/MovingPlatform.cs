using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    private float useSpeed;
    public float directionSpeed = 1.0f;
    float origY;
    public float distance = 2.0f;
    public bool reverse = false;

    // Use this for initialization
    void Start ()
    {
        if (!reverse)
        {
            origY = transform.position.y;
            useSpeed = -directionSpeed;
        }
        else
        {
            origY = transform.position.y;
            useSpeed = directionSpeed;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (origY - transform.position.y > distance)
        {
            useSpeed = directionSpeed; //flip direction
        }
        else if (origY - transform.position.y < -distance)
        {
            useSpeed = -directionSpeed; //flip direction
        }
        transform.Translate(0, useSpeed * Time.deltaTime, 0);
    }
}
