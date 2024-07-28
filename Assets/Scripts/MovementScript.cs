using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
   
    [SerializeField]
    float ballSpeed = 5f;
    
    void Start()
    {
        

    }

 
    void Update()
    {
        Vector3 cubeMovement = transform.position;

        if(Input.GetKey(KeyCode.W))
        {
            cubeMovement.z += ballSpeed * Time.deltaTime;
           
        }
        if (Input.GetKey(KeyCode.S))
        {
            cubeMovement.z -= ballSpeed * Time.deltaTime;
        
        }
        if (Input.GetKey(KeyCode.A))
        {
            cubeMovement.x -= ballSpeed * Time.deltaTime;
          
        }
        if (Input.GetKey(KeyCode.D))
        {
            cubeMovement.x += ballSpeed * Time.deltaTime;
           
        }
          transform.position = cubeMovement;


    }
}
