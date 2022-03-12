using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoomListingContent : MonoBehaviour
{
    [SerializeField] private TMP_Text _roomName;
    [SerializeField] private TMP_Text _numberPlayers;

    public RoomInfo RoomInfo { get; private set; }

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        RoomInfo = roomInfo;
        _roomName.text = $"{roomInfo.Name}";
        _numberPlayers.text = $"{roomInfo.PlayerCount} / {roomInfo.MaxPlayers}";
    }

    public void OnClickJoinRoom()
    {
        Network.JoinRoom(RoomInfo.Name);   
    }
}
