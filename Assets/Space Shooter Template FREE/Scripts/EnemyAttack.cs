using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 1;
    private EnemyHealth enemyHealth;

    private void Start()
    {
        enemyHealth = GetComponent<EnemyHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth player = collision.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.TakeDamage(damage);
            enemyHealth.TakeDamage(999);
        }
    }
}
