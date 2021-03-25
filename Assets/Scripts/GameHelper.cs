using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    public Text textContent;
    public InputField sendedText;
    public InputField userName;
    public ScrollRect scrollWiew;
    public KeyCode _Key;
    public Button sendMsgButton;

    private PlayerHelper _currentPlayer;

    public PlayerHelper CurrentPlayer
    {
        get { return _currentPlayer; }
        set { _currentPlayer = value; }
    }
    private void Update()
    {
        if (Input.GetKeyDown(_Key))
        {
            sendMsgButton.onClick.Invoke();
        }
    }

    public void Send()
    {
        if (sendedText.text != "" && userName.text != "")
        {
            CurrentPlayer.CmdSend(DateTime.Now.ToString("hh:mm") + ". " + userName.text + " : " + sendedText.text + "\n");
            sendedText.text = "";
            sendedText.Select();
            sendedText.ActivateInputField();
            //StartCoroutine(Put());

            //добавить как метод в гейм хелпер
            
        }

    }

   /* public IEnumerator Put()
    {
        WWWForm form = new WWWForm();
        form.AddField("login", userName.text);
        form.AddField("text", sendedText.text);
        form.AddField("datetime", DateTime.Now.ToString());

        //отсылка к хосту(серверу), где лежит наш файл с инструкциями по добавлению данных в бд
        WWW www = new WWW("http://localhost/chat/put.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        Debug.Log(www.text);
    }*/

}
