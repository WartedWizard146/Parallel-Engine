using JetBrains.Annotations;
using UnityEngine;

public class WallBounce : MonoBehaviour
{
    private float random;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            random = Random.Range(90f, 180f);

            other.transform.eulerAngles = new Vector3(other.transform.eulerAngles.x, other.transform.eulerAngles.y + random, 
                other.transform.eulerAngles.z); 
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
