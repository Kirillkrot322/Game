using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinisMenu : MonoBehaviour
{

    
    void Awake()
    {
       gameObject.SetActive(false);
    }

    
    public void LoadWinScreen()
    {
        Debug.Log("Finish");
        gameObject.SetActive(true);
    }

    public void LoadNewLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
