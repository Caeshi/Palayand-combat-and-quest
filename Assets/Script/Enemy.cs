using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public float attackRange;
    public float attackPower;
    public float health;
    private Transform player;
    private Animator animator;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        // Calculate the distance between the enemy and the player
        float distance = Vector3.Distance(transform.position, player.position);
        // Check if the player is within range
        if (distance <= attackRange)
        {
            // Attack the player
            animator.SetTrigger("Attack");
        }
        else
        {
            // Move towards the player
            transform.LookAt(player);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            // Die
            Destroy(gameObject);
        }
    }
}
