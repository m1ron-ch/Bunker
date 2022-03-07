using Photon.Pun;
using Photon.Realtime;
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
