using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    Rigidbody body;
    [SerializeField]
    float jump = 5f;
    bool ground;
    void Start()
    {
       body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && ground)
        {
            body.AddForce(Vector3.up * jump, ForceMode.Impulse);
            ground = false;
        }

    }

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            ground = true;
        }

    }

}
