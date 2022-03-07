using Photon.Pun;
using Photon.Realtime;
using System.Collections.Generic;
using UnityEngine;

public class Network : MonoBehaviourPunCallbacks
{
    private Canvases _canvases;

    public void Initialize(Canvases canvases)
    {
        _canvases = canvases;
    }

    public void RunMethodRPCChangeUserData(List<PlayerListing> listing, string title, string description)
    {
        Debug.Log($"{listing.Count} {PhotonNetwork.LocalPlayer.NickName} {title} {description}");
        base.photonView.RPC("RPCChangeUserData", RpcTarget.AllBufferedViaServer, PhotonNetwork.LocalPlayer, listing, title, description);
    }

    public void RunMethodRPCSetDescriptionData(DescriptionCanvas.BunkerDescription bunkerDescription, DescriptionCanvas.BunkerResources bunkerResources)
    {
        base.photonView.RPC("RPCSetDescriptionData", RpcTarget.AllBufferedViaServer, bunkerDescription, bunkerResources);
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
    private void RPCSetDescriptionData(DescriptionCanvas.BunkerDescription bunkerDescription, DescriptionCanvas.BunkerResources bunkerResources)
    {
        _canvases.GameCanvas.DescriptionCanvas.Instatiate(bunkerDescription, bunkerResources);
/*        _canvases.GameCanvas.DescriptionCanvas.BunkerDescription = Instantiate(_canvases.GameCanvas.DescriptionCanvas.DescriptionContent, _canvases.GameCanvas.DescriptionCanvas.ContentParent);
        _canvases.GameCanvas.DescriptionCanvas.BunkerDescription.SetInfo(bunkerDescription[0].ToString(), bunkerDescription[1].ToString(), _canvases.GameCanvas.DescriptionCanvas.GetNumberFreePlaces(PhotonNetwork.PlayerList.Length));

        _canvases.GameCanvas.DescriptionCanvas.BunkerRecources = Instantiate(_canvases.GameCanvas.DescriptionCanvas.DescriptionContent, _canvases.GameCanvas.DescriptionCanvas.ContentParent);
        _canvases.GameCanvas.DescriptionCanvas.BunkerRecources.SetInfo(bunkerResourcesFieldDescription);*/
    }
}
