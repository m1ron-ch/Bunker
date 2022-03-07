using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    [SerializeField] private MenuCanvas _menuCanvas;

    private IEnumerator _coroutine;

    private void Start()
    {
        _menuCanvas.MainMenuCanvas.ButtonPlay.interactable = false;

        _coroutine = Loading();
        StartCoroutine(_coroutine);

        PhotonNetwork.NickName = PlayerPrefs.GetString(Settings.GetPlayerPrefsNickName);

        AppSettings appSettings = new AppSettings();
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connect to Photon");

        _menuCanvas.MainMenuCanvas.ButtonPlay.interactable = true;

        StopCoroutine(_coroutine);
        _menuCanvas.MainMenuCanvas.ConnectToServer.gameObject.SetActive(false);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarning("Disconnect");
        //PhotonNetwork.RejoinRoom(_menuCanvas.MainMenuCanvas.RoomName.text);
        PhotonNetwork.ReconnectAndRejoin();
    }

    private IEnumerator Loading()
    {
        string points = "";
        while (true)
        {
            yield return new WaitForSeconds(0.3f);

            if(points.Length == 3)
            {
                points = "";
            }
            else
            {
                points += ".";
                _menuCanvas.MainMenuCanvas.Points.text = points;
            }
        }
    }
}
