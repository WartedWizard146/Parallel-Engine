using System;
using UnityEditor.Build;
using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    public GameObject spawner;

    private double x;

    private int y;

    private bool triggered;
    
    private Array swords;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            player.points += 100;

            spawner.GetComponent<SpawnCoins>().count -= 1f;

            x = player.points / 500f;

            y = (int)x;

            triggered = false;

            if (triggered == false)
            {
                if (x == y)
                {
                    if (y != 0)
                    {
                        foreach (SwordProjectile sword in swords)
                        {
                            sword.speed += 0.5f;
                        }
                        triggered = true;
                    }
                }
            }

            Destroy(gameObject);
        }
    }
    void Start()
    {
        spawner = GameObject.Find("Spawner");

        swords = FindObjectsByType<SwordProjectile>(FindObjectsSortMode.None);
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 0.3f, transform.eulerAngles.z);
    }
}
