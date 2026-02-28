using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyHealth>() != null)
        {
            Debug.Log("Bullet hit enemy");
            Destroy(gameObject);
        }
    }
}
