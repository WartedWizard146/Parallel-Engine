using System.Runtime.CompilerServices;
using UnityEngine;

public class SwordProjectile : MonoBehaviour
{
    public float speed;

    public double x;

    int y;

    private PlayerController player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.OnHit();
        }
    }
    void Start()
    {
        player = FindFirstObjectByType<PlayerController>();
    }

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
