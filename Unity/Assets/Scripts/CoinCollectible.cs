using UnityEditor.Build;
using UnityEngine;

public class CoinCollectible : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            player.points += 100;

            Destroy(gameObject);
        }
    }
    void Start()
    {
  
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 0.3f, transform.eulerAngles.z);
    }
}
