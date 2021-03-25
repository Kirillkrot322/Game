using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerSeconds : MonoBehaviour
{
    private float seconds = 0;
    private float minutes = 0;
    public Text textseconds;
    // Start is called before the first frame update
    void Start()
    {
        textseconds.text = seconds.ToString("F2").Replace(",",":");
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60)
        {
            minutes = +1;
            seconds = 0;
        }
        textseconds.text = minutes.ToString()+":" + seconds.ToString("F2").Replace(",", ":");
    }
}
