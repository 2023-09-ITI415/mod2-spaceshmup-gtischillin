using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text enemiesKilledText;
    private int enemiesKilled = 0;

    void Start()
    {
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
