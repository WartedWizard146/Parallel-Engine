using UnityEditor.Build;
using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    public GameObject spawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            player.points += 50;

            spawner.GetComponent<SpawnCoins>().count -= 0.5f;

            Destroy(gameObject);
        }
    }
    void Start()
    {
        spawner = GameObject.Find("Spawner");
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 0.3f, transform.eulerAngles.z);
    }
}
