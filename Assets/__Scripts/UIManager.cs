using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance; // Singleton instance
    public Text enemiesKilledText;
    private int enemiesKilled = 0;

    void Start()
    {
        instance = this; // Set the instance on start

        // Find the Text component
        enemiesKilledText = GetComponentInChildren<Text>();

        // Update the UI initially
        UpdateEnemiesKilledUI();
    }

    public void UpdateEnemiesKilled(int count)
    {
        enemiesKilled += count;
        UpdateEnemiesKilledUI();
    }

    void UpdateEnemiesKilledUI()
    {
        enemiesKilledText.text = "Enemies Killed: " + enemiesKilled.ToString();
    }
}
