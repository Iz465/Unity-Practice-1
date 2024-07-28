using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectileObject;  // The projectile prefab
    [SerializeField]
    float projectileSpeed = 50f;  // Speed of the projectile

    private static int projectileNum = 0;
    private static Queue<GameObject> projectileAmount = new Queue<GameObject>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            GameObject projectile = Instantiate(projectileObject, transform.position + transform.forward, transform.rotation);

           // Allows me access of the rigidbody variable
            Rigidbody projectileBody = projectile.GetComponent<Rigidbody>();

            if (projectileBody != null)
            {
                // Apply force to the projectile
                projectileBody.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);
               
            }
            else
            {
                Debug.LogError("Projectile does not have a Rigidbody component.");
            }
            projectileAmount.Enqueue(projectile);
            projectileNum++;
            Debug.Log("Projectiles shot = " + projectileNum);
            if (projectileNum > 10)
            {
             GameObject lastProjectile = projectileAmount.Dequeue();
                Destroy(lastProjectile);
                projectileNum--;
            }
        }
    }

 

}
