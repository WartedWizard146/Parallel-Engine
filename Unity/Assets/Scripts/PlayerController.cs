using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public int health;

    public float speed;

    public int points;

    private Vector2 move;
    
    private bool canBeDamaged = true;

    private IEnumerator MakeIFrames()
    {
        yield return new WaitForSeconds(1f);
        canBeDamaged = true;
        yield break;
    }

    public void OnHit()
    {
        if (canBeDamaged)
        {
            health = health - 1;
            if (health <= 0)
            {
                if (UnityEditor.EditorApplication.isPlaying)
                {
                    UnityEditor.EditorApplication.isPlaying = false;
                }
                else
                {
                    Application.Quit();
                }
            }
            else
            {
                canBeDamaged = false;
                StartCoroutine(MakeIFrames());
            }
        }
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void MovePlayer()
    {
        if(move.sqrMagnitude > 0.1f)
        {
            Vector3 movement = new Vector3(move.x, 0f, move.y);

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
        
    }
    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }
}
