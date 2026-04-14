using UnityEngine;
using TMPro;

public class PointsText : MonoBehaviour
{
    TMP_Text scoreText;

    private PlayerController player;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();

        player = FindFirstObjectByType<PlayerController>();
    }

    void Update()
    {
        scoreText.text = $"{player.points}";
    }
}
