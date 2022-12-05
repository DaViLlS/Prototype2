using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float _speed = 40.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
