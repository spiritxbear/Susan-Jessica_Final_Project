using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 200f;


    private void OnMouseDrag()
    {
        Debug.Log("DRAGGED");

        float rotX = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, -rotX);
    }
}
