using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public static RespawnScript Instance;
    public GameObject enemy;

 
    Transform respawnPoint; // Both are in the inspector for me to change

    

    public void SetRespawn(Transform respawn)
    {
        respawnPoint = respawn;
    }


    public void RespawnEnemy()
    {
        Debug.Log("Starting Respawn");
        
        StartCoroutine(RespawnCoroutine());
    }

    private IEnumerator RespawnCoroutine()
    {
        Debug.Log("In Coroutine");
        yield return new WaitForSeconds(3f); // Waits for 3 seconds before respawning
      
        
        Instantiate(gameObject, respawnPoint.position, respawnPoint.rotation);
        Debug.Log("Enemy has respawned");
    }

}
