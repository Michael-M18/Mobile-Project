using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Vertical");
        float zDirection = Input.GetAxis("Horizontal");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * Time.deltaTime;
    }
}
