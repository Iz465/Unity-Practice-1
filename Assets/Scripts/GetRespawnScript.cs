using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRespawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
        
        RespawnScript.Instance.SetRespawn(transform);

    }


    void Update()
    {
        
    }
}
