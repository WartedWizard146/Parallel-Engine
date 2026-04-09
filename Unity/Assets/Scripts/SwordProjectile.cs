using UnityEngine;

public class SwordProjectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            player.OnHit();
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
