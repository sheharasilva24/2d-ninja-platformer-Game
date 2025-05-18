using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectilePrefab;
    
    public void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, launchPoint.position, projectilePrefab.transform.rotation);
        Vector3 originalScale = projectile.transform.localScale;

        //flip the projectile(arrow) facing to the player facing direction 
        projectile.transform.localScale = new Vector3(
            originalScale.x * transform.localScale.x > 0 ? 1 : -1,
            originalScale.y,
            originalScale.z 
            );
    }

}
