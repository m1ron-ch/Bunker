using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class UserData : MonoBehaviourPunCallbacks
{
    private string _roomName;
    
    public string RoomName { get { return _roomName; } set { _roomName = value; } }
}

public class UserParams
{
    private string _title;
    private string _description;

    public string Title { get { return _title; } set { _title = value; } }
    public string Description { get { return _description; } set { _description = value; } }
}
