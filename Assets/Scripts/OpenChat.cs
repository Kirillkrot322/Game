using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChat : MonoBehaviour
{
    public GameObject panel;
    public InputField userName;

    
    public void Open_Chat()
    {
        
        if (panel != null && userName.text != "")
        {
            Debug.Log("Open");
            panel.SetActive(true);
        }
    }

    public void Close_Chat()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
}
