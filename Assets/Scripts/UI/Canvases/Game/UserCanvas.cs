using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCanvas : MonoBehaviour
{
    [SerializeField] private UserContent _userContent;
    [SerializeField] private Transform _contentParent;

    private Canvases _canvases;
    private Data _data;
    private Dictionary<string, string> _translateKeywords;
    private int _indexProfession;
    private string _pathAvatars = $"Prefabs/Avatars";

    public Dictionary<string, string> TranslateKeywords { get { return _translateKeywords; } set{ _translateKeywords = value; } }
    public Transform ContentParent { get { return _contentParent; } }
    

    public void StartGame()
    {
        SetUserData();
    }

    public void Initialize(Data data, Canvases canvases)
    {
        _data = data;
        _canvases = canvases;
    }

    private void SetUserData()
    {
        _indexProfession = GetRandomParams(_data.GetData[Keys.Profession.ToString()].Text.Count);
        int _sex = GetRandomParams(_data.GetData[Keys.Sex].Text.Count);

        Instantiate(Resources.Load($"{_pathAvatars}/{((_sex == 0) ? "Mans": "Girls")}/{((_sex == 0) ? "Man": "Girl")}{Random.Range(1, 4)}"), ContentParent);
        Instantiate(_translateKeywords[Keys.Profession.ToString()] + ":", _data.GetData[Keys.Profession.ToString()].Text[_indexProfession]);
        Instantiate($"1. {_translateKeywords[Keys.Skills]}:", _data.GetData[Keys.Skills].Skill[_indexProfession].FirstSkill);
        Instantiate($"2. {_translateKeywords[Keys.Skills]}:", _data.GetData[Keys.Skills].Skill[_indexProfession].SecondSkill = _data.GetData[Keys.SecondSkill].Text[GetRandomParams(_data.GetData[Keys.SecondSkill].Text.Count)]);
        Instantiate($"{_translateKeywords[Keys.Sex]} / {_translateKeywords[Keys.Age]} / {_translateKeywords[Keys.SexualOrientation]}",
            $"{_data.GetData[Keys.Sex].Text[_sex]} / " +
            $"{_data.GetData[Keys.Age].Age} / " +
            $"{_data.GetData[Keys.SexualOrientation].Text[GetRandomWithCoefficient(0.7f, _data.GetData[Keys.SexualOrientation].Text.Count)]}");
        Instantiate(_translateKeywords[Keys.Health] + ":", _data.GetData[Keys.Health].Text[GetRandomWithCoefficient(0.4f, _data.GetData[Keys.Health].Text.Count)]);
        Instantiate(_translateKeywords[Keys.Hobby] + ":", _data.GetData[Keys.Hobby].Text[GetRandomParams(_data.GetData[Keys.Hobby].Text.Count)]);
        Instantiate(_translateKeywords[Keys.CharacterTraits] + ":", _data.GetData[Keys.CharacterTraits].Text[GetRandomParams(_data.GetData[Keys.CharacterTraits].Text.Count)]);
        Instantiate(_translateKeywords[Keys.Phobia] + ":", _data.GetData[Keys.Phobia].Text[GetRandomParams(_data.GetData[Keys.Phobia].Text.Count)]);
        Instantiate(_translateKeywords[Keys.Additionally] + ":", _data.GetData[Keys.Additionally].Text[GetRandomParams(_data.GetData[Keys.Additionally].Text.Count)]);
        Instantiate(_translateKeywords[Keys.SmallLuggage] + ":", _data.GetData[Keys.SmallLuggage].Text[GetRandomParams(_data.GetData[Keys.SmallLuggage].Text.Count)]);
        Instantiate(_translateKeywords[Keys.BigLuggage] + ":", _data.GetData[Keys.BigLuggage].Text[GetRandomParams(_data.GetData[Keys.BigLuggage].Text.Count)]);

    }

    private void Instantiate(string title, string description)
    {
        UserContent content = Instantiate(_userContent, _contentParent);
        content.Initialize(_canvases.GameCanvas.UsersCanvas);
        content.SetInfo(title, description);
    }

    private int GetRandomParams(int count)
    {
        return Random.Range(0, count);
    }

    private int GetRandomWithCoefficient(float coefficient, int count)
    {
        return ((float)Random.Range(0.0f, 1.0f) < coefficient) ? 0 : Random.Range(0, count);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
