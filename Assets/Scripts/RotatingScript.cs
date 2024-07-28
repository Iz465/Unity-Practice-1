using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotatingScript : MonoBehaviour
{
    [SerializeField]
    float rotation = 5f;

    void Start()
    {
        
    }


    void Update()
    {
        float horizontalRotation = Input.GetAxis("Horizontal") * rotation * Time.deltaTime;
        float verticalRotation = Input.GetAxis("Vertical") * rotation * Time.deltaTime;

        transform.Rotate(Vector3.up, horizontalRotation);
        transform.Rotate(Vector3.right, verticalRotation);


    }
}
