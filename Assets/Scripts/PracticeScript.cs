using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PracticeScript : MonoBehaviour
{

    Rigidbody Rigid;
    SphereCollider Sphere;
    [SerializeField]
    float BallSpeed = 50f;
    float ballHeight;

    void Start()
    {
     Rigid = GetComponent<Rigidbody>();
     Sphere = GetComponent<SphereCollider>();
         ballHeight = Sphere.radius * 2;

    }

   
    void Update()
    {
        bool moveKey = false;

      if(Input.GetKey(KeyCode.W))
       {
            Rigid.AddForce(Vector3.up * BallSpeed * Time.deltaTime * 50);
            moveKey = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rigid.AddForce(Vector3.down * BallSpeed * Time.deltaTime * 50);
            moveKey = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rigid.AddForce(Vector3.left * BallSpeed * Time.deltaTime * 50);
            moveKey = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rigid.AddForce(Vector3.right * BallSpeed * Time.deltaTime * 50);
            moveKey = true;
        }
        if (Input.GetKey(KeyCode.Space) && OnGround()) {
     
            Rigid.AddForce(Vector3.up * BallSpeed, ForceMode.Impulse);
        }
        if (!moveKey)
         {
            Rigid.velocity = Vector3.zero;
        }
     
    }

    bool OnGround()
    {
        float groundCheck = Sphere.radius + 0.1f;
          return Physics.Raycast(transform.position, Vector3.down, groundCheck);
         
    }



}
