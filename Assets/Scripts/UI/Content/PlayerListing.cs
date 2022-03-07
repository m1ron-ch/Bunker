using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerListing : MonoBehaviour
{
    [SerializeField] private TMP_Text _name;


    private List<UserParams> _userParams = new List<UserParams>();
    private UserContent _userContent;

    public Player Player { get; private set; }
    public List<UserParams> UserParams { get { return _userParams; } }

    public void Initialize(UserContent userContent)
    {
        _userContent = userContent;
    }

    public void SetPlayerInfo(Player player)
    {
        Player = player;
        _name.text = $"{player.ActorNumber}. {player.NickName}";
    }

    public void AddUserData(UserParams userParams)
    {
        _userParams.Add(userParams);
        UserContent content = Instantiate(_userContent, gameObject.transform);
        content.SetInfo(userParams.Title, userParams.Description);
    }
}
