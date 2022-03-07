using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DescriptionContent : MonoBehaviour
{
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private TMP_Text _numberFreePlaces;

    #region Words For Localization
    private string _wordNumberPlaces;
    #endregion

    public string Title { get { return _title.text; } }
    public string Description { get { return _description.text; } }
    public string NumberFreePlace { get { return _numberFreePlaces.text; } }

    public void Initialize(string wordNumberPlaces)
    {
        _wordNumberPlaces = wordNumberPlaces;
    }

    public void SetInfo(string description)
    {
        _description.text = description;
    }

    public void SetInfo(string bunkerName, string description, int numberPlaces)
    {
        _title.text = bunkerName;
        _description.text = description;
        UpdateNumberPlaces(numberPlaces);
    }

    public void UpdateNumberPlaces(int numberPlaces)
    {
        _numberFreePlaces.text = $"{_wordNumberPlaces}: {numberPlaces}";
    }
}
