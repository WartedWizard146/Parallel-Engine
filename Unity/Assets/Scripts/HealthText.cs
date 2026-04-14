using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{
    TMP_Text healthText;

    private PlayerController player;

    void Start()
    {
        healthText = GetComponent<TMP_Text>();

        player = FindFirstObjectByType<PlayerController>();
    }
    void Update()
    {
        healthText.text = $"{player.health}";
       
    }
}
