using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    [SerializeField] private Canvases _canvases;



    public void OnClickBackInMenuFromGame()
    {
        _canvases.GameCanvas.Hide();
        _canvases.MenuCanvas.Show();

        Network.LeaveRoom();
    }

    public void OnClickBackInMainMenuFromInformation()
    {
        _canvases.MenuCanvas.InformationCanvas.Hide();
        _canvases.MenuCanvas.MainMenuCanvas.Show();
    }
}
