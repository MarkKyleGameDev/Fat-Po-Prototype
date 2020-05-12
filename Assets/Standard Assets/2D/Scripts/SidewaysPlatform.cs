using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidewaysPlatform : MonoBehaviour
{

    private float useSpeed;
    public float directionSpeed = 1.0f;
    float origY;
    public float distance = 2.0f;
    public bool reverse = false;

    // Use this for initialization
    void Start()
    {
        if (!reverse)
        {
            origY = transform.position.x;
            useSpeed = -directionSpeed;
        }
        else
        {
            origY = transform.position.x;
            useSpeed = directionSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (origY - transform.position.x > distance)
        {
            useSpeed = directionSpeed; //flip direction
        }
        else if (origY - transform.position.x < -distance)
        {
            useSpeed = -directionSpeed; //flip direction
        }
        transform.Translate(useSpeed * Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = transform;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
}
