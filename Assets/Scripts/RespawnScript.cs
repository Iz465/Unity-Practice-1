using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public static RespawnScript Instance;

    public GameObject enemy; // Assign your enemy prefab in the Inspector
    public Transform respawnPoint; // Assign a respawn point in the Inspector

    private void Awake()
    {
        // This is called the singleton pattern. makes it so only one instance is made to keep info in only one
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        respawnPoint = GameObject.Find("RespawnPoint").transform;
    }

    public void RespawnEnemy()
    {
        Debug.Log("Starting Respawn");

        StartCoroutine(RespawnCoroutine());
    }

    private IEnumerator RespawnCoroutine()
    {
        Debug.Log("In Coroutine");
        yield return new WaitForSeconds(3f); // Wait for 3 seconds before respawning
      
        
        Instantiate(enemy, respawnPoint.position, respawnPoint.rotation);
        Debug.Log("Enemy has respawned");
    }

}
