using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] private DescriptionCanvas _descriptionCanvas;
    [SerializeField] private UserCanvas _userCanvas;
    [SerializeField] private UsersCanvas _usersCanvas;

    public DescriptionCanvas DescriptionCanvas { get { return _descriptionCanvas; } }
    public UserCanvas UserCanvas { get { return _userCanvas; } }
    public UsersCanvas UsersCanvas { get { return _usersCanvas; } }

    [SerializeField] private Data _data;

    private Canvases _canvases;

    public void StartGame()
    {
        _descriptionCanvas.StartGame();
        _userCanvas.StartGame();
    }

    public void Initialize(Canvases canvases)
    {
        _canvases = canvases;
        _descriptionCanvas.Initialize(_data, _canvases);
        _userCanvas.Initialize(_data, _canvases);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
