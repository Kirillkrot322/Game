using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlayer : MonoBehaviour
{
    public DeathMenu deathmenu;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player")) {
            Destroy(collision.gameObject);
            deathmenu.LoadDeathScreen();
        }

    }
}
