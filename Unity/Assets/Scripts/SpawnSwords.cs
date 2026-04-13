using System.Collections;
using UnityEngine;

public class SpawnSwords : MonoBehaviour
{
    public GameObject sword;

    private int xpos;

    public float ypos;

    private int zpos;

    private float zrot;

    public int numberToSpawn;

    private int count;

    IEnumerator Spawn()
    {
        while(count < numberToSpawn)
        {
            xpos = Random.Range(-6, 6);
            zpos = Random.Range(-4, 6);

            zrot = Random.Range(0f, 360f);

            Instantiate(sword, new Vector3(xpos, ypos, zpos), Quaternion.Euler(90f, 0f, zrot));
            
            yield return count += 1;
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
