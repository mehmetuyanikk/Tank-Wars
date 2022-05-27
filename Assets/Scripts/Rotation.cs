using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public void Rotate(Transform _transfrom, float _rotateSpeed)
    {
        Vector3 movement = new Vector3(150f, 0, 150f);
        Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);

        _transfrom.rotation = Quaternion.RotateTowards(_transfrom.rotation, toRotation, _rotateSpeed * Time.deltaTime);
    }
}
