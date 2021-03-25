using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerHelper : NetworkBehaviour
{
    GameHelper _gameHelper;
    // Start is called before the first frame update
    void Start()
    {
        _gameHelper = GameObject.FindObjectOfType<GameHelper>();

        if (isLocalPlayer)
        {
            _gameHelper.CurrentPlayer = this;
        }
    }

    [Command]

    public void CmdSend(string message)
    {
        Debug.Log("Send: "+message);
        RpcSend(message);
    }

    [ClientRpc]

    public void RpcSend(string message)
    {
         _gameHelper.textContent.text += message;

        Canvas.ForceUpdateCanvases();
        _gameHelper.scrollWiew.verticalNormalizedPosition = 0f;
        Canvas.ForceUpdateCanvases();
    }

}
