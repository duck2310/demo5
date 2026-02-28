using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 1;
    public GameObject explosionPrefab;

    protected int currentHealth;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Instantiate(
            explosionPrefab,
            transform.position,
            transform.rotation
        );

        Destroy(gameObject);
    }
}
