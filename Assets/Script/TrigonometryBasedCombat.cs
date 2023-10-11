using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigonometryBasedCombat : MonoBehaviour
{
    public Transform player;
    public Transform target;

    void Update()
    {
        // Calculate the angle between the player and the target
        float angle = CalculateAngle(player.position, target.position);

        // Update the player's rotation to face the target
        player.rotation = Quaternion.Euler(0, angle, 0);

        // Calculate the distance between the player and the target
        float distance = CalculateDistance(player.position, target.position);

        // Check if the player's attack hits the target
        if (distance <= player.GetComponent<Attack>().attackRange)
        {
            target.GetComponent<Health>().TakeDamage(player.GetComponent<Attack>().attackPower);
        }
    }

    float CalculateAngle(Vector3 from, Vector3 to)
    {
        Vector3 direction = to - from;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        return angle;
    }

    float CalculateDistance(Vector3 from, Vector3 to)
    {
        float distance = Vector3.Distance(from, to);
        return distance;
    }
}