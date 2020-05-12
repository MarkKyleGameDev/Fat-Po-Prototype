using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                other.transform.position = GameVariables.checkpoint;
            }
        }
    }
}
