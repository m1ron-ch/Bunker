using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuCanvas : MonoBehaviourPunCallbacks
{
    #region Fields
    [SerializeField] private UserData _userData;
    [SerializeField] private Back _back;
    [SerializeField] private TMP_InputField _username;
    [SerializeField] private TMP_InputField _roomName;
    [SerializeField] private TMP_Text _nameOfTheGame;
    [SerializeField] private TMP_Text _connectToServer;
    [SerializeField] private TMP_Text _points;
    [SerializeField] private TMP_Text _error;
    [SerializeField] private Button _butttonPlay;
    [SerializeField] private TMP_Text _rulesOfTheGame;
    #endregion

    [SerializeField] private Canvases _canvases;

    #region Words For Localization
    public string WordField { get; set; }
    public string WordEmpty { get; set; }
    #endregion

    public bool IsGameRun { get; private set; } = false;

    #region Properties
    public TMP_InputField Username { get { return _username; } set { _username = value; } }
    public TMP_InputField RoomName { get { return _roomName; } set { _roomName = value; } }
    public TMP_Text ConnectToServer { get { return _connectToServer; } set { _connectToServer = value; } }
    public TMP_Text NameOfTheGame { get { return _nameOfTheGame; } set { _nameOfTheGame = value; } }
    public TMP_Text Error { get { return _error; } set { _error = value; } }
    public TMP_Text Points { get { return _points; } }
    public Button ButtonPlay { get { return _butttonPlay; } }
    public TMP_Text RulesOfTheGame { get { return _rulesOfTheGame; } set { _rulesOfTheGame = value; } }
    #endregion


    private void Start()
    {
        _username.text = PlayerPrefs.GetString(Settings.GetPlayerPrefsNickName);
        _roomName.text = "Test room";
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

        if(_roomName.text == _userData.RoomName)
        {
            _canvases.MenuCanvas.Hide();
            _canvases.GameCanvas.Show();
            return;
        }
        else if(PhotonNetwork.InRoom)
        {
            PhotonNetwork.LeaveRoom();
            return;
        }

        JoinOrCreateRoom();
    }

    public void OnClickInformation()
    {
        _back.CurrentCanvas = _canvases.MenuCanvas.InformationCanvas.gameObject;
        _back.PreviousCanvas = _canvases.MenuCanvas.MainMenuCanvas.gameObject;

        _canvases.MenuCanvas.InformationCanvas.Show();
        _canvases.MenuCanvas.MainMenuCanvas.Hide();
    }

    public void OnClickAbout()
    {
        _back.CurrentCanvas = _canvases.MenuCanvas.AboutCanvas.gameObject;
        _back.PreviousCanvas = _canvases.MenuCanvas.MainMenuCanvas.gameObject;

        _canvases.MenuCanvas.MainMenuCanvas.Hide();
        _canvases.MenuCanvas.AboutCanvas.Show();
    }

    public override void OnCreatedRoom()
    {
        ActionAfterConnectedOnRoom();
    }

    public override void OnJoinedRoom()
    {
        ActionAfterConnectedOnRoom();
    }

    public override void OnLeftRoom()
    {
        Debug.Log("Left Room");

        if(PhotonNetwork.IsConnectedAndReady)
            JoinOrCreateRoom();
    }

    public void ActionAfterConnectedOnRoom()
    {
        DestroyGameData();
        StartGame();

        _userData.RoomName = _roomName.text;
        IsGameRun = true;

        _back.CurrentCanvas = _canvases.GameCanvas.gameObject;
        _back.PreviousCanvas = _canvases.MenuCanvas.gameObject;

        _canvases.MenuCanvas.Hide();
        _canvases.GameCanvas.Show();
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

    private void JoinOrCreateRoom()
    {
        PhotonNetwork.NickName = _username.text;
        PlayerPrefs.SetString(Settings.GetPlayerPrefsNickName, _username.text);

        Network.JoinOrCreateRoom(_roomName.text, 16);
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

    private void StartGame()
    {

        if (_userData.RoomName != _roomName.text || _userData.RoomName == null)
        {
            _canvases.GameCanvas.StartGame();
        }
    }

    private void DestroyGameData()
    {
        if (_userData.RoomName != _roomName.text && _userData.RoomName != null)
        {
            Transform[] contentParants = { _canvases.GameCanvas.DescriptionCanvas.ContentParent, _canvases.GameCanvas.UserCanvas.ContentParent,
                _canvases.GameCanvas.UsersCanvas.ContentParent };
            
            foreach(Transform contentParant in contentParants)
            {
                foreach(Transform content in contentParant)
                {
                    Destroy(content);
                }
            }
        }
    }
}
