using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket2 : MonoBehaviour
{

    private void FixedUpdate()
    {
        Tank2();
    }

    void Tank2()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(150f, 0, 0) * Time.deltaTime;
            //transform.rotation = new Quaternion(0, 1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-150f, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, 150) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -150f) * Time.deltaTime;
        }
    }
}
