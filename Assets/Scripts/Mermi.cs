using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] float _mermiHiz;

    private void FixedUpdate()
    {
        mermi();
    }

    void mermi()
    {
        _rigidBody.velocity = Vector3.forward * _mermiHiz;
    }
}
