using UnityEngine;
using UnityEngine.Networking;

[System.Obsolete]
public class StartServerManager : NetworkManager
{
    public void Start()
    {
        NetworkManager.singleton.StartServer();
    }
}
