using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    void Update()
    {
        if (transform.position.z > topBound)
            Destroy(gameObject);
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GameOver!");
            Destroy(gameObject);
        }
    }
}
