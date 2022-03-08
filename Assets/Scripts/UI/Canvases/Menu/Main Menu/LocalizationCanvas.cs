using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationCanvas : MonoBehaviour
{
    private class Language
    {
        private string _lang;
        private GameObject _langObj;
        private Action _invokeMethod;

        public string Lang { get { return _lang; } set { _lang = value; } }
        public GameObject LangObj { get { return _langObj; } set { _langObj = value; } }
        public Action InvokeMethod { get { return _invokeMethod; } set { _invokeMethod = value; } }
    }

    [SerializeField] private Localization _localization;
    [SerializeField] private GameObject _russian;
    [SerializeField] private GameObject _english;

    private List<Language> _languages = new List<Language>();
    private GameObject _currentLangObj;
    private int _currentLang = 0;

    private void Start()
    {
        InitializeLanguages();
        InitializeLanguage(Application.systemLanguage.ToString());
    }

    public void OnClickEditLocalization()
    {
        NextLang();
    }

    private void InitializeLanguages()
    {
        _languages.Add(new Language { Lang = "Russian", LangObj = _russian, InvokeMethod = _localization.SetRussianLanguage });
        _languages.Add(new Language { Lang = "English", LangObj = _english, InvokeMethod = _localization.SetEnglishLanguage });
    }

    private void InitializeLanguage(string language)
    {
        foreach (Language lang in _languages)
        {
            _currentLang++;
            if (lang.Lang == language)
            {
                SetLanguage(lang);
                return;
            }
        }   
    }

    private void NextLang()
    {
        if(_currentLang == _languages.Count)
        {
            _currentLang = 0;
        }

        SetLanguage(_languages[_currentLang]);
        _currentLang++;
    }

    private void SetLanguage(Language language)
    {
        _currentLangObj?.SetActive(false);
        _currentLangObj = language.LangObj;
        language.InvokeMethod?.Invoke();
        language.LangObj.SetActive(true);
    }
}
