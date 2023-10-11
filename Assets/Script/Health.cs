using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;
    void Update()
    {
        // Check if the target is dead
        if (currentHealth <= 0)
        {
            // Destroy the target
            Destroy(gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        // Reduce the target's health by the specified amount
        currentHealth -= damage;
    }
}