using UnityEngine;
using UnityEngine.Networking;

[System.Obsolete]
public class StartClientManager : NetworkManager
{
    public void Start()
    {
        NetworkManager.singleton.StartClient(); 
        NetworkManagerHUD hud = FindObjectOfType<NetworkManagerHUD>();
        if (hud != null)
            hud.showGUI = false;
    }
}
