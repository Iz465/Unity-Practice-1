using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    float health = 100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        
    }
   public void hit()
    {
        health -= 20f; // always add = sign like -= or +=.  wont work otherwise
            Debug.Log(health);
        if (health <= 0)
        {
            Debug.Log("Dead");
         
            RespawnScript.Instance.RespawnEnemy(); // this starts the respawnenemy function to respawn the enemy. // this is not activating right now
           
            Debug.Log("Starting Destroy");
            Destroy(gameObject);
            
        }
    }
}
