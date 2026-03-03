using UnityEngine;

public class Caller : MonoBehaviour
{
    public Receiver receiver;
    
    void Start()
    {
        Debug.Log("Caller: calling Receiver.OnCalled()");
        receiver.OnCalled();
    }
}
