using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    [SerializeField] private Canvases _canvases;



    public void OnClickBackFromGameInMenu()
    {
        _canvases.GameCanvas.Hide();
        _canvases.MenuCanvas.Show();

        Network.LeaveRoom();
    }

    public void OnClickBackFromInformationInMainMenu()
    {
        _canvases.MenuCanvas.InformationCanvas.Hide();
        _canvases.MenuCanvas.MainMenuCanvas.Show();
    }
}
