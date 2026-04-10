using UnityEngine;

public class SwordProjectile : MonoBehaviour
{
    public float speed;

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
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
