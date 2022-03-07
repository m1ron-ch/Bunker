using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvases : MonoBehaviour
{
    [SerializeField] private MenuCanvas _menuCanvas;
    [SerializeField] private GameCanvas _gameCanvas;

    public MenuCanvas MenuCanvas { get { return _menuCanvas; } }
    public GameCanvas GameCanvas { get { return _gameCanvas; } }

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        MenuCanvas.Initialize(this);
        GameCanvas.Initialize(this);
    }
}
