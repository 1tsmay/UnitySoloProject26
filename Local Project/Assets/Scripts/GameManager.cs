using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.AdaptivePerformance.Editor;
using System;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public PlayerController player;

    public Image healthBar;

    public GameObject pauseMenu;

    public bool paused = false;
    public bool enemiesGone = false;

    public int enemyCount = 0;

    }

// Start is called once before the first execution of Update after the MonoBehaviour is created


public class EntityDeath : MonoBehaviour
{
    // temporary placeholder 
    public Action playerDeath = null;

    public void Update()
    {
        var entityDeath = GameObject.FindGameObjectWithTag("Chomper") || GameObject.FindGameObjectWithTag("Watcher") || GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 endpoint = new Vector3(0f, -30.0f, 0f);

        if ((transform.position == endpoint) && !(transform.Find("Player")))
        {
            Destroy(gameObject);
        }
        else
        {
            playerDeath();
        }
    }
}








