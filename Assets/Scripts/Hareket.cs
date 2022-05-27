using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{

    [SerializeField] Transform _transfrom;

    private void FixedUpdate()
    {
        Tank1();
    }

    void Tank1()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += new Vector3(150f, 0, 0) * Time.deltaTime;

            //transform.rotation = new Quaternion(0, 1f, 0, 0);

            transform.Rotate (0, 150 * Time.deltaTime, 0);

            //Vector3 movement = new Vector3(150f, 0, 150f);
            //Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);

            //_transfrom.rotation = Quaternion.RotateTowards(_transfrom.rotation, toRotation, 100f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-150f, 0, 0) * Time.deltaTime;

            //Vector3 movement = new Vector3(150f, 0, 0f);
            //Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);

            //_transfrom.rotation = Quaternion.RotateTowards(_transfrom.rotation, toRotation, 100f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 150) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -150f) * Time.deltaTime;
        }
    }

}
