using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserContent : MonoBehaviour
{
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private GameObject _buttonClose;
    [SerializeField] private GameObject _buttonOpen;

    private UsersCanvas _usersCanvas;

    public void Initialize(UsersCanvas userCanvas)
    {
        _usersCanvas = userCanvas;
    }

    public void SetInfo(string title, string description)
    {
        _title.text = title;
        _description.text = description;
    }

    public void OnOpenUserInfo()
    {
        _buttonClose.SetActive(false);
        _buttonOpen.SetActive(true);
        _usersCanvas.OpenUserData(_title.text, _description.text);
    }
}
