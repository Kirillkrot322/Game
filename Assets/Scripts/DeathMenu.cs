using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public GameObject controllerPanel;
    void Start()
    {
        gameObject.SetActive(false);
    }

    

    public void LoadDeathScreen() {
        Debug.Log("Death");
        gameObject.SetActive(true);
        controllerPanel.SetActive(false);
    }
}
