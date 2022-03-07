using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuCanvas : MonoBehaviourPunCallbacks
{
    [SerializeField] private UserData _userData;
    [SerializeField] private TMP_InputField _username;
    [SerializeField] private TMP_InputField _roomName;
    [SerializeField] private TMP_Text _nameOfTheGame;
    [SerializeField] private TMP_Text _connectToServer;
    [SerializeField] private TMP_Text _points;
    [SerializeField] private TMP_Text _error;
    [SerializeField] private Button _butttonPlay;

    private Canvases _canvases;

    #region Words For Localization
    public string WordField { get; set; }
    public string WordEmpty { get; set; }
    #endregion

    public bool IsGameRun { get; private set; } = false;

    public TMP_InputField Username { get { return _username; } set { _username = value; } }
    public TMP_InputField RoomName { get { return _roomName; } set { _roomName = value; } }
    public TMP_Text ConnectToServer { get { return _connectToServer; } set { _connectToServer = value; } }
    public TMP_Text NameOfTheGame { get { return _nameOfTheGame; } set { _nameOfTheGame = value; } }
    public TMP_Text Error { get { return _error; } set { _error = value; } }
    public TMP_Text Points { get { return _points; } }
    public Button ButtonPlay { get { return _butttonPlay; } }

    private void Start()
    {
        _username.text = PlayerPrefs.GetString(Settings.GetPlayerPrefsNickName);
        //_roomName.text = "Test room";
    }

    public void OnClickPlay()
    {
        if (!IsCheckEmptyField())
        {
            return;
        }

        if (!PhotonNetwork.IsConnected)
        {
            return;
        }

        PhotonNetwork.NickName = _username.text;
        PlayerPrefs.SetString(Settings.GetPlayerPrefsNickName, _username.text);

        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 20;

        PhotonNetwork.JoinOrCreateRoom(_roomName.text, roomOptions, TypedLobby.Default);
    }

    public void OnClickSettings()
    {
        _canvases.MenuCanvas.Hide();
    }

    public void OnClickInformation()
    {
        _canvases.MenuCanvas.InformationCanvas.Show();
        _canvases.MenuCanvas.MainMenuCanvas.Hide();
    }

    public void OnClickAbout()
    {
        _canvases.MenuCanvas.Hide();
    }

    public override void OnCreatedRoom()
    {
        ActionAfterConnectedOnRoom();
    }

    public override void OnJoinedRoom()
    {
        ActionAfterConnectedOnRoom();
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log($"Room creation failed ({message})");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log($"Room join failed ({message})");
    }

    public void Initialize(Canvases canvases)
    {
        _canvases = canvases;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private bool IsCheckEmptyField()
    {
        if (_username.text == null || _username.text == "")
        {
            StartCoroutine(SmoothText(_username.placeholder.GetComponent<TMP_Text>().text));

            return false;
        }
        else if (_roomName.text == null || _roomName.text == "")
        {
            StartCoroutine(SmoothText(_roomName.placeholder.GetComponent<TMP_Text>().text));

            return false;
        }

        return true;
    }

    private IEnumerator SmoothText(string errorNameField)
    {
        string msg = GetErrorMessage(errorNameField);
        _error.text = msg;

        _error.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);

        _error.gameObject.SetActive(false);
    }

    private string GetErrorMessage(string errorNameField)
    {
        errorNameField = errorNameField.Replace(".", "");
        return $"{WordField} \"{errorNameField}\" {WordEmpty}";
    }

    private void ActionAfterConnectedOnRoom()
    {
        DestroyGameData();
        StartGame();

        _userData.RoomName = _roomName.text;
        IsGameRun = true;

        _canvases.MenuCanvas.Hide();
        _canvases.GameCanvas.Show();
    }

    private void StartGame()
    {
        if (_userData.RoomName != _roomName.text || _userData.RoomName == null)
        {
            _canvases.GameCanvas.StartGame();
        }
    }

    private void DestroyGameData()
    {
        if (_userData.RoomName != null && _userData.RoomName != _roomName.text)
        {
            foreach (Transform child in _canvases.GameCanvas.DescriptionCanvas.ContentParent.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in _canvases.GameCanvas.UserCanvas.ContentParent.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
