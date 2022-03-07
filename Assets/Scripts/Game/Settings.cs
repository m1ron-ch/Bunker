using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    private const string PlayerPrefsNickName = "NickName";

    public static string GetPlayerPrefsNickName { get { return PlayerPrefsNickName; } }

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 120;
    }
}
