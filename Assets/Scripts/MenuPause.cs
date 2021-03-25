using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPause : MonoBehaviour
{
    public GameObject pausemenuUI;
    
    void Start()
    {
        pausemenuUI.SetActive(false);
    }


    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0);
    } 

    public void GamePause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
