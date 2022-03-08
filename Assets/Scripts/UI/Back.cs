using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    [SerializeField] private Canvases _canvases;

    private GameObject _currentCanvas;
    private GameObject _previousCanvas;

    public GameObject CurrentCanvas { get { return _currentCanvas; } set { _currentCanvas = value; } }
    public GameObject PreviousCanvas { get { return _previousCanvas; } set { _previousCanvas = value; } }

    private void Start()
    {
        _currentCanvas = _canvases.MenuCanvas.MainMenuCanvas.gameObject;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            _currentCanvas?.SetActive(false);
            _previousCanvas?.SetActive(true);
        }
    }

/*    public void OnClickBackFromGameInMenu()
    {
        _canvases.GameCanvas.Hide();
        _canvases.MenuCanvas.Show();

        Network.LeaveRoom();
    }

    public void OnClickBackFromInformationInMainMenu()
    {
        _canvases.MenuCanvas.InformationCanvas.Hide();
        _canvases.MenuCanvas.MainMenuCanvas.Show();
    }*/
}
