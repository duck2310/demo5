using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float time = 0.5f;

    void Start()
    {
        Destroy(gameObject, time);
    }
}
