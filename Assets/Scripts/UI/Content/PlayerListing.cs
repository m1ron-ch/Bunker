using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerListing : MonoBehaviour
{
    [SerializeField] private TMP_Text _name;
    [SerializeField] private GameObject _pointer;

    private List<GameObject> _userParams = new List<GameObject>();
    private UserContent _userContent;
    private bool _isShowInfo = true;
    private float _seconds = 0.5f;

    public Player Player { get; private set; }
    //public List<UserParams> UserParams { get { return _userParams; } }

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
        UserContent content = Instantiate(_userContent, gameObject.transform);
        content.SetInfo(userParams.Title, userParams.Description);
        _userParams.Add(content.gameObject);
    }

    public void OnClickUserInfoShowHide()
    {
        if(_userParams.Count == 0)
        {
            return;
        }

        if (_isShowInfo)
        {
            HideUserInfo();
        }
        else
        {
            ShowUserInfo();
        }

        _isShowInfo = !_isShowInfo;
    }

    private void ShowUserInfo()
    {
        foreach (GameObject userParams in _userParams)
        {
            userParams.SetActive(true);
        }

        StartCoroutine(RotationPointer(90));
    }

    private void HideUserInfo()
    {
        foreach (GameObject userParams in _userParams)
        {
            userParams.SetActive(false);
        }

        StartCoroutine(RotationPointer(-90));
    }

    private IEnumerator RotationPointer(int angelZ)
    {
        float t = 0;
        while (t <= 1)
        {
            t += Time.deltaTime / _seconds;

            _pointer.transform.rotation = Quaternion.Lerp(_pointer.transform.rotation, Quaternion.Euler(0, 0, angelZ), Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }
    }
}
