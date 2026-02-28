using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval = 0.2f;
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

    private float lastBulletTime;

    private AudioSource audioSource;   // <-- thêm

    void Start()
    {
        audioSource = GetComponent<AudioSource>();   // <-- thêm
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }

    void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    void ShootBullet()
    {
        Instantiate(
            bulletPrefabs,
            transform.position + bulletOffset,
            transform.rotation
        );

        if (audioSource != null)      
        {
            audioSource.Play();       
        }
    }
}