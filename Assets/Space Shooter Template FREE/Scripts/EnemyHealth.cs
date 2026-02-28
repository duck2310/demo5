using UnityEngine;

public class EnemyHealth : Health
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage(1);
        }
    }
}
