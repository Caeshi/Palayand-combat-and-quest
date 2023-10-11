using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float maxHealth;
    public float currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            // Die
            Destroy(gameObject);
        }
    }
}
