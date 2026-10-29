using System;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerController player;

    public Image healthBar;

    public GameObject PauseMenu;

    public bool paused = false;
    public bool enemiesGone = false;

    public int enemyCount = 0;






    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        // myAnim = GetComponent<Animator>();
    }

    public class EntityDeath : MonoBehaviour
    {
        // temporary placeholder 
        public Action playerDeath = null;

        public void Update()
        {
            var entityDeath = GameObject.FindGameObjectWithTag("Chomper") || GameObject.FindGameObjectWithTag("Watcher") || GameObject.FindGameObjectWithTag("Player").transform;
            Vector3 endpoint = new Vector3(0f, -100.0f, 0f);

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

    public void Pause()
    {
        paused = !paused;

        if (paused)
        {
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
        }
    }

    public void LoadLevel(int levelID)
    {
        if (levelID > SceneManager.sceneCountInBuildSettings)
            Debug.Log("Level ID is too high: " + levelID);
        else
            SceneManager.LoadScene(levelID);
    }


    public void NextNevel()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PrevLevel()
    {
        LoadLevel(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void MainMenu()
    {
        LoadLevel(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
    }









