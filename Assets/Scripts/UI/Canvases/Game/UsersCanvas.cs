using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UsersCanvas : MonoBehaviourPunCallbacks
{
    [SerializeField] private Network _network;
    [SerializeField] private Transform _content;
    [SerializeField] private PlayerListing _playerListing;
    [SerializeField] private UserContent _userContent;
    [SerializeField] private TMP_Text _users;

    private List<PlayerListing> _listings = new List<PlayerListing>();
    private Canvases _canvases;
    private int _numberPlayers = 0;

    public int NumberPlayers { get { return _numberPlayers; } }
    public TMP_Text Users { get { return _users; } set { _users = value; } }

    public override void OnEnable()
    {
        base.OnEnable();
        GetCurrentRoomPlayers();
    }

    public override void OnDisable()
    {
        base.OnDisable();
        for (int i = 0; i < _listings.Count; i++)
        {
            Destroy(_listings[i].gameObject);
        }
        _listings.Clear();
    }

    public void Initialize(Canvases canvases)
    {
        _canvases = canvases;
    }

    private void GetCurrentRoomPlayers()
    {
        foreach (KeyValuePair<int, Player> player in PhotonNetwork.CurrentRoom.Players)
        {
            AddPlayerListing(player.Value);

/*            PlayerListing playerListing = new PlayerListing();
            foreach (PlayerListing listing in _listings)
            {
                if(listing.Player.NickName == player.Value.NickName)
                {
                    playerListing = listing;
                    return;
                }
            }
            foreach (UserParams userParams in playerListing.UserParams)
            {
                UserContent content = Instantiate(_userContent, gameObject.transform);
                content.SetInfo(userParams.Title, userParams.Description);
            }*/
        }

        if (PhotonNetwork.CurrentRoom.PlayerCount > _numberPlayers)
        {
            _numberPlayers = PhotonNetwork.CurrentRoom.PlayerCount;
        }
    }

    private void AddPlayerListing(Player player)
    {
        int index = _listings.FindIndex(x => x.Player == player);
        if (index != -1)
        {
            _listings[index].SetPlayerInfo(player);
        }
        else
        {
            PlayerListing listing = Instantiate(_playerListing, _content);
            if (listing != null)
            {
                listing.Initialize(_userContent);
                listing.SetPlayerInfo(player);

                _listings.Add(listing);
            }
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        AddPlayerListing(newPlayer);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        int index = _listings.FindIndex(x => x.Player == otherPlayer);
        if (index != -1)
        {
            Destroy(_listings[index].gameObject);
            _listings.RemoveAt(index);
        }
    }

    public void OpenUserData(string title, string description)
    {
        //_network.RunMethodRPCChangeUserData(_listings, title, description);
        base.photonView.RPC("RPCChangeUserData", RpcTarget.AllBufferedViaServer, PhotonNetwork.LocalPlayer, title, description);
    }

    [PunRPC]
    private void RPCChangeUserData(Player player, string title, string description)
    {
        int index = _listings.FindIndex(x => x.Player == player);
        if (index != -1)
        {
            _listings[index].AddUserData(new UserParams { Title = title, Description = description });
        }
    }
}
