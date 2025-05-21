using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLayers : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}