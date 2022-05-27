using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation1 : Rotation
{

    [SerializeField] Transform _transfrom;
    [SerializeField] float _rotateSpeed;

    Rotation _rotation;

    private void FixedUpdate()
    {
        Rotation();
    }

    private void Awake()
    {
        _rotation = new Rotation();
    }

    void Rotation()
    {
        _rotation.Rotate(_transfrom, _rotateSpeed);
    }
}
