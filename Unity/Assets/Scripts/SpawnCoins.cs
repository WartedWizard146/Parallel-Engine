using System.Collections;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coin;

    private float xpos;

    public float ypos;

    private float zpos;

    public int maxNumberOnScreen;

    public float count;

    IEnumerator Spawn()
    {
        while(count < maxNumberOnScreen)
        {
            xpos = Random.Range(-6.5f, 6.5f);
            zpos = Random.Range(-6.5f, 6.5f);

            Instantiate(coin, new Vector3(xpos, ypos, zpos), Quaternion.identity);

            count += 1f;

            yield return new WaitForSeconds(4);
        }
    }

    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
        
    }
}
