using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DescriptionCanvas : MonoBehaviour
{
    public struct BunkerDescription
    {
        public string Name;
        public string Area;
        public string TimeSpent;
        public string FoodSupplies;
    }

    public struct BunkerResources
    {
        public string Location;
        public string Resources;
        public string Premises;
    }

    [SerializeField] private Network _network;
    [SerializeField] private DescriptionContent _descriptionContent;
    [SerializeField] private Transform _contentParent;
    [SerializeField] private TMP_Text _description;

    #region Words For Localization
    public string WordBunker { get; set; }
    public string WordArea { get; set; }
    public string WordTimeSpent { get; set; }
    public string WordFoodSupplies { get; set; }
    public string WordLocation { get; set; }
    public string WordResources { get; set; }
    public string WordPremises { get; set; }
    public string WordYear { get; set; }
    public string WordYears { get; set; }
    public string WordYearsForRussian { get; set; }
    public string WordMonth { get; set; }
    public string WordMonths { get; set; }
    public string WordMonthsForRussian { get; set; }
    public string WordNumberPlaces { get; set; }
    #endregion

    private Data _data;
    private Canvases _canvases;
    private DescriptionContent _bunkerDescriptionContent;

    public DescriptionContent BunkerDescriptionContent { get { return _bunkerDescriptionContent; } }
    public Transform ContentParent { get { return _contentParent; } }
    public TMP_Text Desciption { get { return _description; } set { _description = value; } }

    public void StartGame()
    {        
        SetInformationData();
    }

    public void Initialize(Data data, Canvases canvases)
    {
        _canvases = canvases;
        _data = data;
    }

    private void SetInformationData()
    {
        _network.Initialize(_canvases);

        if (PhotonNetwork.IsMasterClient)
        {
            BunkerDescription bunkerDescription = new();
            bunkerDescription.Area = _data.GetData[Keys.BunkerArea].Text[GetRandomParams(_data.GetData[Keys.BunkerArea].Text.Count)];
            bunkerDescription.Name = _data.GetData[Keys.BunkerName].Text[GetRandomParams(_data.GetData[Keys.BunkerName].Text.Count)];
            bunkerDescription.TimeSpent = $"{GetYearAddition(Random.Range(1, 13))} {GetMonthAddition(Random.Range(1, 13))}";
            bunkerDescription.FoodSupplies = $"{GetYearAddition(Random.Range(1, 13))} {GetMonthAddition(Random.Range(1, 13))}";

            BunkerResources bunkerRescources = new();
            bunkerRescources.Location = _data.GetData[Keys.BunkerPlace].Text[GetRandomParams(_data.GetData[Keys.BunkerPlace].Text.Count)];
            bunkerRescources.Resources = GetDescriptionAboutBunker(Keys.BunkerResources, 1, 7);
            bunkerRescources.Premises = GetDescriptionAboutBunker(Keys.BunkerBuildings, 4, 7);

            string bunkerDescriptionJson = JsonConvert.SerializeObject(bunkerDescription);
            string bunkerRescourcesJson = JsonConvert.SerializeObject(bunkerRescources);

            _network.RunMethodRPCSetDescriptionData(bunkerDescriptionJson, bunkerRescourcesJson);
        }
    }

    public void Instatiate(string bunkerDescriptionJson, string bunkerResourcesJson)
    {
        BunkerDescription bunkerDescription = JsonConvert.DeserializeObject<BunkerDescription>(bunkerDescriptionJson);
        BunkerResources bunkerResources = JsonConvert.DeserializeObject<BunkerResources>(bunkerResourcesJson);

        _bunkerDescriptionContent = Instantiate(_descriptionContent, _contentParent);
        _bunkerDescriptionContent.Initialize(WordNumberPlaces);
        _bunkerDescriptionContent.SetInfo($"{WordBunker} {bunkerDescription.Name}\n ", $"{WordArea}: {bunkerDescription.Area} ì\u00B2\n" +
            $"{WordTimeSpent}: {bunkerDescription.TimeSpent}\n" +
            $"{WordFoodSupplies}: {bunkerDescription.FoodSupplies}", GetNumberPlacesInBunker(Network.GetNumberPlayers()));

        DescriptionContent resources = Instantiate(_descriptionContent, _contentParent);
        resources.SetInfo($"{WordLocation}: {bunkerResources.Location}\n\n" +
            $"{WordResources}: {bunkerResources.Resources}\n\n" +
            $"{WordPremises}: {bunkerResources.Premises}");
    }

    public int GetNumberPlacesInBunker(int numberPlayers)
    {
        switch (numberPlayers)
        {
            case 0:
            case 1:
            case 2:
            case 3:
                return 1;
            case 4:
            case 5:
                return 2;
            case 6:
            case 7:
                return 3;
            case 8:
            case 9:
                return 4;
            case 10:
            case 11:
                return 5;
            case 12:
            case 13:
                return 6;
            case 14:
            case 15:
                return 7;
            case 16:
            case 17:
                return 8;
            default:
                return 9;
        }
    }

    public string GetDescriptionAboutBunker(string key, int minNumber, int maxNumber)
    {
        List<string> information = _data.GetData[key].Text;
        string str = "";
        int count = Random.Range(minNumber, maxNumber), index;

        for (int i = 0; i < count; i++)
        {
            index = GetRandomParams(information.Count);

            str += $" {information[index]}";
            str += (i + 1 == count) ? "." : ",";

            information.RemoveAt(index);
        }

        return str;
    }

    private int GetRandomParams(int count)
    {
        return Random.Range(0, count);
    }

    private string GetYearAddition(int year)
    {
        if(year >= 20)
        {
            return "";
        }

        switch (year)
        {
            case 1:
                return $"{year} {WordYear}";
            case 2:
            case 3:
            case 4:
                return $"{year} {WordYears}";
            default:
                return $"{year} {((WordYearsForRussian == null) ? WordYears : WordYearsForRussian)}";
        }
    }

    private string GetMonthAddition(int month)
    {
        switch (month)
        {
            case 1:
                return $"{month} {WordMonth}";
            case 2:
            case 3:
            case 4:
                return $"{month} {WordMonths}";
            default:
                return $"{month}  {((WordMonthsForRussian == null) ? WordMonths : WordMonthsForRussian)}";
        }

    }
}
