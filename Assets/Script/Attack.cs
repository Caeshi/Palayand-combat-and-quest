using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Attack : MonoBehaviour
{
    public float attackRange;
    public float attackPower;
    void Update()
    {
        // Check if the player is attacking
        if (Input.GetMouseButtonDown(0))
        {
            // Get the target's position
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Calculate the distance between the player and the target
            float distance = Vector3.Distance(transform.position, targetPosition);
            // Check if the target is within range
            if (distance <= attackRange)
            {
                // Get the target's health component
                Health health = gameObject.GetComponent<Health>();
                // Deal damage to the target
                health.TakeDamage(attackPower);
            }
        }
    }
}