using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Network : MonoBehaviourPunCallbacks
{
    private Canvases _canvases;

    public static int GetNumberPlayers()
    {
        return PhotonNetwork.PlayerList.Length;
    }

    public void Initialize(Canvases canvases)
    {
        _canvases = canvases;
    }

    public static void JoinRoom(string name)
    {
        PhotonNetwork.JoinRoom(name);
    }

    public static void JoinLobyy()
    {
        PhotonNetwork.JoinLobby();
    }

    public static bool IsMasterClient()
    {
        return PhotonNetwork.IsMasterClient;
    }

    public static void JoinOrCreateRoom(string roomName, int numberPlayers)
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = Convert.ToByte(numberPlayers);
        roomOptions.PlayerTtl = 10000;

        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log($"Room creation failed ({message})");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log($"Room join failed ({message})");
    }

    public void RunMethodRPCChangeUserData(List<PlayerListing> listing, string title, string description)
    {
        Debug.Log($"{listing.Count} {PhotonNetwork.LocalPlayer.NickName} {title} {description}");
        base.photonView.RPC("RPCChangeUserData", RpcTarget.AllBufferedViaServer, PhotonNetwork.LocalPlayer, listing, title, description);
    }

    public void RunMethodRPCSetDescriptionData(string bunkerDescriptionJson, string bunkerResourcesJson)
    {
        base.photonView.RPC("RPCSetDescriptionData", RpcTarget.AllBufferedViaServer, bunkerDescriptionJson, bunkerResourcesJson);
    }

    public static void LeaveRoom() => PhotonNetwork.LeaveRoom();
    

    [PunRPC]
    private void RPCChangeUserData(Player player, List<PlayerListing> listings, string title, string description)
    {
        Debug.Log(listings.Count);
        int index = listings.FindIndex(x => x.Player == player);
        if (index != -1)
        {
            Debug.Log("RPC");
            listings[index].AddUserData(new UserParams { Title = title, Description = description });
        }
    }

    [PunRPC]
    private void RPCSetDescriptionData(string bunkerDescriptionJson, string bunkerResourcesJson)
    {
        _canvases.GameCanvas.DescriptionCanvas.Instatiate(bunkerDescriptionJson, bunkerResourcesJson);
    }
}
