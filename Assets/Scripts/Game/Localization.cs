using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Localization : MonoBehaviour
{
    private class English
    {
        public void SetLanguage()
        {

        }
    }

    private class Russian
    {
        public void SetLanguage()
        {
            
        }
    }

    [SerializeField] private Canvases _canvases;
    [SerializeField] private Data _data;

    private void Awake()
    {
        // SetLanguage(Application.systemLanguage.ToString());
    }

    private void SetLanguage(string language)
    {
        switch (language)
        {
            case "Russian":
            case "Belarusian":
            case "Ukrainian":
                SetRussianLanguage();
                break;
            default:
                SetEnglishLanguage();
                break;    
        }
    }

    public void SetRussianLanguage()
    {
        #region Menu
        #region Main Menu
        _canvases.MenuCanvas.MainMenuCanvas.NameOfTheGame.text = "������";
        _canvases.MenuCanvas.MainMenuCanvas.Username.placeholder.GetComponent<TMP_Text>().text = "��� ������������...";
        _canvases.MenuCanvas.MainMenuCanvas.RoomName.placeholder.GetComponent<TMP_Text>().text = "�������� �������...";
        _canvases.MenuCanvas.MainMenuCanvas.ButtonPlay.GetComponentInChildren<TMP_Text>().text = "������";
        _canvases.MenuCanvas.MainMenuCanvas.ConnectToServer.text = "����������� � �������";
        _canvases.MenuCanvas.MainMenuCanvas.RulesOfTheGame.text = "������� ����";
        _canvases.MenuCanvas.MainMenuCanvas.WordField = "����";
        _canvases.MenuCanvas.MainMenuCanvas.WordEmpty = "������";
        #endregion
        #region Settings
        #endregion
        #region Information 
        _canvases.MenuCanvas.InformationCanvas.Title.text = "������� ���� ������л";
        _canvases.MenuCanvas.InformationCanvas.Subtitle.text = "������л - ��� ������������� ��������� ���� � �������������������� �������.";
        _canvases.MenuCanvas.InformationCanvas.PlotTitle.text = "�����:";
        _canvases.MenuCanvas.InformationCanvas.PlotDescription.text = "�� ����� ��������� ����������. ����� ����� ��������� ����� ������������� �������, � ������ ������� ������� � ���� � ������. �� ���������� ������������ ���� ����������: � ������ ������ ������ ��������, ��������� ��������� � ����.\n\n" +
            "������ ���� �������� �����������, �� �������� ��������� ������, ��� �� ����� �������� � ������. ��������� ����� ���������� ��� � ��������� �����.\n\n" + 
            "������ ������ ������� ����� �������� ����� ��� �������������� ����� �� �������������������� �������. ������ ��� ������� � ������.\n\n" + 
            "� ������� ��������� ���� ����� �������������: ���������, ��������, ������������� ��������������, �����, �����, �������������� ������, ������������ ��������.�� ��� ��������� ��������� ���������, ��������� �� ����� ������� ����� ������ �� �������. ������ � ������� ���, ������ ��������� � ����������� ����� �������� � �������������.";
        _canvases.MenuCanvas.InformationCanvas.PurposeOfTheGameTitle.text = "���� ����:";
        _canvases.MenuCanvas.InformationCanvas.PurposeOfTheGameDescription.text = "������� ������ ������ �����, ������� ������ ���������� ���� ����� ���������.";
        _canvases.MenuCanvas.InformationCanvas.RulesOfTheGameTitle.text = "������� ����:";
        _canvases.MenuCanvas.InformationCanvas.RulesOfTheGameDescription.text = "�� 3 - 16 �������\n\n" +
            "������� ������ ��������� ������� ���� ��������� �� ���������� ����������������, ������ ��� ���������, ��������, ���, �������, ����������� ���������, �����, ������, ��������, �����. ����� ������ ����� ������� ����� �������� � ������, ������� ����� ������������ � ���� ������ � ����� ������.\n\n" +
            "� ������ ������ ������ ����� ������ ������� ��������� ������ ���������. � ������ ��������� ������ ������ ��������� ����� ���� �������������� � ����� �������������� ����� ���������� � �������. � ����� ������� ������, ������� �� �������, ���������� ����������� �� ������ ������������ ������, ������� ������������ �������� �� ������������ �� ����� � ������� � ������ �� ����� ����������� � ���������� � �����������. ���� �������������, ����� ������� ��������� ������� �� ������� ���� � �������.";
        #endregion
        #region About
        #endregion       
        #endregion

        #region Game
        #region Description Canvas
        _canvases.GameCanvas.DescriptionCanvas.Desciption.text = "��������";
        _canvases.GameCanvas.DescriptionCanvas.WordBunker = "������";
        _canvases.GameCanvas.DescriptionCanvas.WordArea = "�������";
        _canvases.GameCanvas.DescriptionCanvas.WordTimeSpent = "����� ����������";
        _canvases.GameCanvas.DescriptionCanvas.WordFoodSupplies = "������ ��� ��";
        _canvases.GameCanvas.DescriptionCanvas.WordLocation = "������������";
        _canvases.GameCanvas.DescriptionCanvas.WordResources = "�������";
        _canvases.GameCanvas.DescriptionCanvas.WordPremises = "���������";
        _canvases.GameCanvas.DescriptionCanvas.WordYear = "���";
        _canvases.GameCanvas.DescriptionCanvas.WordYears = "����";
        _canvases.GameCanvas.DescriptionCanvas.WordYearsForRussian = "���";
        _canvases.GameCanvas.DescriptionCanvas.WordMonth = "�����";
        _canvases.GameCanvas.DescriptionCanvas.WordMonths = "������";
        _canvases.GameCanvas.DescriptionCanvas.WordMonthsForRussian = "�������";
        _canvases.GameCanvas.DescriptionCanvas.WordNumberPlaces = "���������� ����";
        #endregion
        #region User Canvas
        #endregion
        #region Users Canvas
        _canvases.GameCanvas.UsersCanvas.Users.text = "������";
        #endregion
        #endregion

        _canvases.GameCanvas.UserCanvas.TranslateKeywords = new Dictionary<string, string>
        {
            {  Keys.Profession, "���������" },
            {  Keys.Skills, "�����������" },
            {  Keys.Sex, "���" },
            {  Keys.Age, "�������" },
            {  Keys.SexualOrientation, "����������� ���������" },
            {  Keys.Health, "��������" },
            {  Keys.Hobby, "�����" },
            {  Keys.CharacterTraits, "����� ���������" },
            {  Keys.Phobia, "�����" },
            {  Keys.Additionally, "�������������" },
            {  Keys.SmallLuggage, "����� �����" },
            {  Keys.BigLuggage, "������� �����" },

        };

        _data.SetData = new Dictionary<string, DataParams>
        {
            {
                "Profession", new DataParams
                {
                    Text = new List<string>
                    {
                        "����������", "�����������" , "�������", "�������", "����� / �������",
                        "������", "���������", "�������", "��������", "���������", "���������", "������", "���������",
                        "�������", "�����", "���������", "��������������", "���", "����������", "������", "�������", "�������", "���������",
                        "������������", "����������", "��������", "������", "������", "�����", "������������", "�������", "���������", "������������",
                        "�����", "���������", "���������", "������", "����������", "�������", "�������", "�����", "����� �����", "�����������",
                        "������", "�������", "���������", "�����", "������","����������", "���������", "�����", "���������", "�����", "������",
                        
                        "���������������� ������� � �������", "���������� ����� ��� ��������", "���������� ����������", "���������������� ����������", "�������� �������",
                        "����� �����������", "���������� ����", "�������� ��� ��������", "���������������� ���������", "��������� ���", "������ �����������", "�������� ��������"
                        
                    }
                }
            },
            {
                "Skills", new DataParams
                {
                    Skill = new List<Skill>
                    {
                         new Skill { FirstSkill = "����� �������� ���� ��������� �� ���������, ���� �� �� ������ 18 ��� ������ 27 ���. � ��������� ������ ���������� ��������.", SecondSkill = "����� ������� ��� ��� ��� ������."},
                         new Skill { FirstSkill = "�����, ��� ��������� ���.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ���� � ����������.",  },
                         new Skill { FirstSkill = "���� ��� �� ���� ����� ������������� ����� �� ����, ������� ��� ������ ������-�� ������.",  },
                         new Skill { FirstSkill = "����� ������������ ����������� ��������� ������ ������.",  },
                         new Skill { FirstSkill = "���� ��� �� ���� ����� �������� ��������� �������� ����������� (������ �������)� ������ ������.",  },
                         new Skill { FirstSkill = "����� ������� ���� �������� ��������� ���������� ������.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ������ ����� ��������.",  },
                         new Skill { FirstSkill = "����� �������� ������� ����� ���� �������.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ����� � ������ �������� (������� ������ �� 24 ���� �������� �����).",  },
                         new Skill { FirstSkill = "����� �������� ���������� ��� � ������� � \"� ����������\" �� \"� �������\" � ��������.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ����.",  },
                         new Skill { FirstSkill = "��������� � ��������� ����� �������� (�� 50 ��.)",  },
                         new Skill { FirstSkill = "��� ��������� � ������ �������� � ����� ���� � �����.",  },
                         new Skill { FirstSkill = "���� ��� �� ���� ����� ������ ��� ���������� � ����� ��������",  },
                         new Skill { FirstSkill = "��������� � ��������� ������������� ������� (1 ��.) �� ��������-��������� ��������.",  },
                         new Skill { FirstSkill = "��������� � ��������� �������� � 28 ����",  },
                         new Skill { FirstSkill = "����� ������� ��������� � ������� ������.",  },
                         new Skill { FirstSkill = "����� ���� ��� �� ���� �������� ������",  },
                         new Skill { FirstSkill = "������ ��� ���� �� ��������� � ����� ������� ������ �������, ��� ������ � ������������� ��������.",  },
                         new Skill { FirstSkill = "��� ��������� � ������ ����������� ��������� ���� �� �������� �������� �����.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ����� ���������.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ����� ��� �����������.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ������ �������������.",  },
                         new Skill { FirstSkill = "�������� � ������ � ��������, ��������� � ���������. ��������� ���� � ��������� 10 �. ������ �������.",  },
                         new Skill { FirstSkill = "�� ������� ����� �������� �������� ����� ����� ��� �����, ���� ����� �� ���� ����������.",  },
                         new Skill { FirstSkill = "���� ��� �� ���� ����� �������� ����� �������, ������� ������� \"������\" ��� \"�������\" ������ ������, ����� ����.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ������.",  },
                         new Skill { FirstSkill = "��������� ���� � ��������� ������.",  },
                         new Skill { FirstSkill = "��� ��������� � ������ � ��������� ���������� �������������� ��������� ��� ���.",  },
                         new Skill { FirstSkill = "��� ��������� � ������ ������ ������� � ������� ������������� ������� ��� ����������� ��������.",  },
                         new Skill { FirstSkill = "��� ����������� � ������ ��������� ������������� ��������� �������. ������ ������� ��� ���� �� ��������.",  },
                         new Skill { FirstSkill = "����� ���������������� ���� ������� �������������� \"���. ��������\".",  },
                         new Skill { FirstSkill = "����� ������� ������������� �� ������� �������. �������� 1 ��� �� ����.",  },
                         new Skill { FirstSkill = "����� ������� ��������� � ������ ������.",  },
                         new Skill { FirstSkill = "��� ����������� ����� ������� 1 ����� ������ ����."},
                         new Skill { FirstSkill = "��������� ���� � ��������� 5�� �������������� ����."},
                         new Skill { FirstSkill = "��������� � ��������� ������ ������ 2 �������� (�� 100 �.) � ���� ������ ������� �� ���������."},
                         new Skill { FirstSkill = "����� ��������� ������� ������� �������������� ����������� �� ������� �������� (���� ��� �� ����).\n* ������ ��������� ��� ������ � �������� ������� ������� \"�����������\".\n* �������� ������� ����������."},
                         new Skill { FirstSkill = "��������� ���� � ��������� ���� 0.5 � (1 ����) � ������ �����."},
                         new Skill { FirstSkill = "��������� 10 ��. �������� � ���� ���������."},
                         new Skill { FirstSkill = "����� ����������� �������� �������� � ���������������� ����."},
                         new Skill { FirstSkill = "����� ���������������� ������������� ������ ������, ����� ����."},
                         new Skill { FirstSkill = "����� ��������� ����� ������� � ������� �� 2 �������."},
                         new Skill { FirstSkill = "����� ������� �������������� �������������� �� ����� ���� (���� ��� �� ����)."},
                         new Skill { FirstSkill = "��������� � ������ ����� �������. ������ ������� �� ��������."},
                         new Skill { FirstSkill = "���� ��� ����������� ������ �������� ������ ���������� ������� - ����� ������ ���� �������. ������� ����� ������� ���� ��� �� ����."},
                         new Skill { FirstSkill = "��������� 2 �� ���� � ���������."},
                         new Skill { FirstSkill = "����� ������� \"300\" � �������� � ��������� 2 �� �����."},
                         new Skill { FirstSkill = "�����, ��� ��������� ����� � �������������."},
                         new Skill { FirstSkill = "��������� ���� � ��������� ������� � �������� �����������."},
                         new Skill { FirstSkill = "�������� ���������� ���������� ��� ����� �������, ��� ��� ������ �� ��� 1 �����."},
                         new Skill { FirstSkill = "����� ������ (��� ����������� �� ������ ������ �������) ����� �� ������������� � ������ ��� ���������� �����������."},
                         new Skill { FirstSkill = "����� ������������ � ������� � ������� ������ ������ (�� �����)"},

                         new Skill { FirstSkill = ""},
                    }
                }
            },
            {
                "SecondSkill", new DataParams
                {
                    Text = new List<string>
                    {
                        "��������� ���� ����� � ������", "��������� �������� �� ������ ������ ������ ������ ����� ���", "����� �������� ���� �� ������ ������� � ������", "������� �� ������� ����", "�������� ������ ������ �� ���� ��� (����� ���)",
                        "����� ������� ��������� ����� � �������", "����� ����� �� ������ ���������� ���� �����", "��������� �������� ����� ������� ������", "����� ����� �� ���� ������ ������� � ������", "������ ��������� � ����",
                        "����� ��� ��������� ������ � ����� ���������-�������� (��������� �������� / �������: 25-45 ���)", "��������� ���������� ������� � ������ �������", "����� ������� ��������� ����", "������� �� ������� ������",
                        "��������� ������������ �����2 ������ �� ������", "��������� � ������ ������", "��� ������ ��� ������ ��������� �� ����������� �������",
                        "����� ����������� ����� �������", "����� ��� ��������� ������ � ���������� ������������ ���������", "������ ���������� ��������� � ������ �������",
                        "������ ���������� ���������� � ������ �������", "������� ����� �� �������", "����� ��� ��������� ������ �� ����� ��������� ��������(��������� ��������/�������: 20-45 ���);"
                    }
                }
            },
            {
                "Sex", new DataParams
                {
                    Text = new List<string>
                    {
                        "�������", "�������"
                    }
                }
            },
            {
                "Age", new DataParams
                {

                }
            },
            {
                "SexualOrientation", new DataParams
                {
                    Text = new List<string>
                    {
                        "�������������", "���", "���������", "���������", "���� (��������)", "��������", "���������", "������������", "�����������", "�����������", "����������", "�����������"
                    }
                }
            },
            {
                "Health", new DataParams
                {
                    Text = new List<string>
                    {
                        "�������� ������", $"���� {Random.Range(1, 5)} �������", "�������� ������", "���� ���� �� ������, ������ � ������� (����������)", "���������", "������", "���������", "���������", "�������",
                        "�����", "������� �", "���", "Covid-19", "�������", "������", "������������", "������� ������������ ��������", "�����", "�������", $"���� (���� ����� {Random.Range(2, 4)} ����", "� ����� ������",
                        "�������", "���������", "��� �����", "���������� ������ �������", "��� ����� (����� ����� ���)", "������", "�����", "��������", "��������", "�����", "", "��������"
                    }
                }
            },
            {
                "Hobby", new DataParams
                {
                    Text = new List<string>
                    {
                        "��������������� ����� � ������", "�������� ����� � ��������", "������������", "�������� ����-������ �� ����� ����", "���������� ���������", "�����", "������� ����", "�����������", "�������", "�������� �� ������",
                        "��������", "���� ����", "������ ��� ��������", "������������", "��������", "����� �� ���������", "���������� ����", "�����������", "�������� ������", "����������� � ������� ��������",
                        "����������� ��������", "�����������", "�����������", "��������", "������ ��������", "������ ��������", "������������� ��������� (� ���� ���� ������)", "��������", "�������� �� ����", "����", "��������� ��������",
                        "����������������", "������� � ����������������� � ����������� �������� ��������", "C����������", "�����������", "������ ���������", "������������ �������������", "��������� ����", "������", "��������������� ������"
                    }
                }
            },
            {
                "CharacterTraits", new DataParams
                {
                    Text = new List<string>
                    {
                        "�������", "���������", "��������", "������������", "��������", "����", "������������", "���������", "��������", "������", "��������", "��������������", "��������", "�����������", "������������",
                        "�����������", "�����������", "��������������", "�����������", "�����������", "����������", "������� �����", "���������", "������������", "���������������", "�����������", "��������", "����������", "�������������",
                        "���������", "�����������", "�����������", "����", "���������", "���������������", "�������������", "��������", "��������", "������", "�����������", "�����������", "��������", "����������", "�����������"
                    }
                }
            },
            {
                "Phobia", new DataParams
                {
                    Text = new List<string>()
                    {
                        "����", "����������� � ������ ����", "��������� � ������ ��������", "��������� � ������ ����", "����������� � ������ �����", "��������� � ������ �����", "�������������", "������������� � ������ �������", "����������� � ������ ����",
                        "����������� � ������ ������", "����������� � ������ ������", "���������� � ������ �������", "������������� � ������ ��������", "���������������� � ������ ����", "������������ � ������ ������ �����",
                        "������������� � ������ ��������", "���������� � ������ ���������", "������������� � ������ ���������� �����������", "��������� � ������ ���������", "������������ � ������ ������", "���������� � ������ ��������",
                        "���������� � ������ ������", "��������� � ������ ������", "��������� � ������ ������", "����������� � ������ ����������� �� �������", "����������", "��������� � ������ ����",
                        "���������� � ������ �����������", "������������� � ������ ��������", "����������� � ������ ��������", "���������� � ������ ������ ������", "����������� � ������ �����", "������������ � ������ ����",
                        "������������ � ������ ������� � ���������� ������������"
                    }
                }
            },
            {
                "Additionally", new DataParams
                {
                    Text = new List<string>
                    {
                        "������������", "������ ����� ������ ����������", "�����", "����", "������� ���� �����", "����� ��������������� �����������", "����� ��� ��������� ������� ����� �� ���� ������",
                        "����� ��� ��������� ������� ��� �� ��� ������", "���������� ���", "������ ����� � ���������", "�������", "����� ������������", "��������(�) ����� �����������",
                        "��������� ����������� ������", "�������(�) ��� ���������", "�������� ������������� �������", "������� ����������� ������", "����", "������� � ��������", "���������", "����� ��� ���",
                        "����� ������", "����� ������������ ������", "����� ��������� ��������", "��� ���������� ������� ��������", "����� � �����������", "�����", "����� � ����", "����� � �������", "���������� ������",
                        "�����(�) ����� ��� ��������� �� ����������� �������", "�������� ������� ��������", "������������(�) ���� ������", "����� ����� ������� ������ ������", "������(�) ����� ���������", "��������",
                        "���������� ������� ����", "������� ��������", "����� ������ ����� �����", "������ �� ������", "������� �� ���� �������� �������", "������ � ������. ������� ������ �� �������� ��������", "������� �� ���������",
                        "������������ ������ ����", "����� �������� �����", "����� 4 ��� ����������� � ����������", "������� ������� ������ �����", "������ ������� ��������"
                    }
                }
            },
            {
                "SmallLuggage", new DataParams
                {
                    Text = new List<string>
                    {
                        "�����", "�����", "�������", "�������", "����� ������", "��������", "������� ����� ��������", "����", "������ ��������� �������", "����", "������", "�������", "������� � �������� ���������",
                        "����� �������� ������������", "��������", "������ �������������", $"����� ������� ({Random.Range(1, 8)} ��)", "�����", "������", "������������ �������", "������ ��������", "������ (������)",
                        $"���� ������� ({Random.Range(1, 4)} ��)", "������ ��� �������", "������� ��� ���� (5�)", "�������", "�������", "��� �� ���� ������", "������", "���������", "����� �� ��������", "���������� ���", "��������� ���",
                        "������ �����", "���� � �����", "���� ���", "������", "���������", "������", "������", "�������� ������", "�������������� �����", "���������� ����� � �������", "������������",
                        "����", "��������", "�������", "���", "������", "�������", "�������", "�����", "�������", "�������", "����� � ������� �����", "���������� ���", "������� ��� ��������� (24 ��)", "��� ����� ����",
                        "������� �����", "������ ����������� ����������� �����", "������� ������", "�������", "������ ���������", "������� � ������", "�������� �����", "������������� ����", "������ � �����������",
                        "����� ������������", "�����"

                    }
                }
            },
            {
                "BigLuggage", new DataParams
                {
                    Text = new List<string>
                    {
                        "������� ����� ��������", "������������", "���������", "���������", "������ � ���� �� 3 ������", "���������", "�����", "����� ��������� ������ (100 �)", "����� ��������� ������ ������",
                        "����������� ���� ������� �� 521 ������", "���������� ���� (3 ��)", "������� � 3-� �������", "������ ��� (2 ��)", "������ ��� ������� ���", "������������ �����", "�����������", "�������� �������",
                        "��� �� ���� �����", "���������", "�������� �����", "�������", "����", "������������ �����", "�������� ����������� �������", "�������� �������", "�������� ����� ������ �4",
                        "�����������", "������", "����", "�����", "�����", "������ �� ������", "�������", "�4", "�������", "�������������", "�������", "���� � ������ ��������", "��� ������", "����", "���", "������"
                    }
                }
            },
            {
                "BunkerName", new DataParams
                {
                    Text = new List<string>
                    {
                        "77", "����", "�����", "1771", "��. 99", "������", "������", "���", "����", "������", "����", "����", "�����", "������", "������", "������ 997", "��������",
                    }
                }
            },
            {
                "BunkerPlace", new DataParams
                {
                    Text = new List<string>
                    {
                        "�������", "����������", "���", "����������� ������", "�����", "�������", "������ ���������", "�������", "�������", "����", "������", "������", "����", "�������� ���������", "����������", "��������",
                    }
                }
            },
            {
                "BunkerArea", new DataParams
                {
                    Text = new List<string>
                    {
                        "47", "100", "89", "55", "170", "139", "350", "320", "120", "80", "300", "187", "145", "200", "250", "240", "129", "192", "77", "215"
                    }
                }
            },
            {
                "BunkerResources", new DataParams
                {
                    Text = new List<string>
                    {
                        "�������", "������ ������", "����� ������ ������", "���������� �� ��������� � ����", "�����;", "����� ������������", "��������", "������ �������", "������� ������ ������",
                        "���������� �������", "��������� ���������", "��������� � ��������", "����� ���������", "����� �������� �����", "����� ����", "�����", "�������", "�������", "�����",
                        "��������� �����", $"����� � ������� �� {Random.Range(1, 9)} ��. ������", "����", "������� � �������", "�������", "����� ���������", "��������� ��", "����", "������", "�������",
                        "����", "����", "���������� �����", "����������", "������� ������� ��� ������ � �������", "������ ������", "����������� c �������� �������"
                    }
                }
            },
            {
                "BunkerBuildings", new DataParams
                {
                    Text = new List<string>
                    {
                        "�������", "��������� �������", "������� �������", "��������", "���. �����������", "����� � ���������", "����������� ��� ������������", "��������������", "������ �����", "������� �������",
                        "��������� � ��������", "���������� � �������������", "����������", "������������", "��������", "������� ��� (�� ������)", "��������� � �������� �������",
                        "����������� ��� ����� ����", "����� � �������", "������", "������� ������ ������ ��������", "�������������� ������������", "���������� �������", "������� �������������� ����������",
                        "��������������� ����� ��� ���������� �� ������������", "������������ ����������� �������", "��������� ��������", "��������� �������� ������", "��������� ���. �����������", "���������",
                        "������������ ���������", "���������� ���������", $"���������� �������� ������� � {Random.Range(1, 7)} ��. �������", "������ �������"
                    }
                }
            }
        };
    }

    public void SetEnglishLanguage()
    {
        #region Menu
        #region Main Menu
        _canvases.MenuCanvas.MainMenuCanvas.NameOfTheGame.text = "BUNKER";
        _canvases.MenuCanvas.MainMenuCanvas.Username.placeholder.GetComponent<TMP_Text>().text = "Usernamer...";
        _canvases.MenuCanvas.MainMenuCanvas.RoomName.placeholder.GetComponent<TMP_Text>().text = "Room name...";
        _canvases.MenuCanvas.MainMenuCanvas.ButtonPlay.GetComponentInChildren<TMP_Text>().text = "Play";
        _canvases.MenuCanvas.MainMenuCanvas.ConnectToServer.text = "Connect to server";
        _canvases.MenuCanvas.MainMenuCanvas.RulesOfTheGame.text = "Rules of the game";
        _canvases.MenuCanvas.MainMenuCanvas.WordField = "Field";
        _canvases.MenuCanvas.MainMenuCanvas.WordEmpty = "empty";
        #endregion
        #region Settings
        #endregion
        #region Information 
        _canvases.MenuCanvas.InformationCanvas.Title.text = "������� ���� ������л";
        _canvases.MenuCanvas.InformationCanvas.Subtitle.text = "������л - ��� ������������� ��������� ���� � �������������������� �������.";
        _canvases.MenuCanvas.InformationCanvas.PlotTitle.text = "�����:";
        _canvases.MenuCanvas.InformationCanvas.PlotDescription.text = "�� ����� ��������� ����������. ����� ����� ��������� ����� ������������� �������, � ������ ������� ������� � ���� � ������. �� ���������� ������������ ���� ����������: � ������ ������ ������ ��������, ��������� ��������� � ����.\n\n" +
            "������ ���� �������� �����������, �� �������� ��������� ������, ��� �� ����� �������� � ������. ��������� ����� ���������� ��� � ��������� �����.\n\n" +
            "������ ������ ������� ����� �������� ����� ��� �������������� ����� �� �������������������� �������. ������ ��� ������� � ������.\n\n" +
            "� ������� ��������� ���� ����� �������������: ���������, ��������, ������������� ��������������, �����, �����, �������������� ������, ������������ ��������.�� ��� ��������� ��������� ���������, ��������� �� ����� ������� ����� ������ �� �������. ������ � ������� ���, ������ ��������� � ����������� ����� �������� � �������������.";
        _canvases.MenuCanvas.InformationCanvas.PurposeOfTheGameTitle.text = "���� ����:";
        _canvases.MenuCanvas.InformationCanvas.PurposeOfTheGameDescription.text = "������� ������ ������ �����, ������� ������ ���������� ���� ����� ���������.";
        _canvases.MenuCanvas.InformationCanvas.RulesOfTheGameTitle.text = "������� ����:";
        _canvases.MenuCanvas.InformationCanvas.RulesOfTheGameDescription.text = "�� 3 - 16 �������\n\n" +
            "������� ������ ��������� ������� ���� ��������� �� ���������� ����������������, ������ ��� ���������, ��������, ���, �������, ����������� ���������, �����, ������, ��������, �����. ����� ������ ����� ������� ����� �������� � ������, ������� ����� ������������ � ���� ������ � ����� ������.\n\n" +
            "� ������ ������ ������ ����� ������ ������� ��������� ������ ���������. � ������ ��������� ������ ������ ��������� ����� ���� �������������� � ����� �������������� ����� ���������� � �������. � ����� ������� ������, ������� �� �������, ���������� ����������� �� ������ ������������ ������, ������� ������������ �������� �� ������������ �� ����� � ������� � ������ �� ����� ����������� � ���������� � �����������. ���� �������������, ����� ������� ��������� ������� �� ������� ���� � �������.";
        #endregion
        #region About
        #endregion
        #endregion

        #region Game
        #region Description Canvas
        _canvases.GameCanvas.DescriptionCanvas.Desciption.text = "DESCRIPTION";
        _canvases.GameCanvas.DescriptionCanvas.WordBunker = "Bunker";
        _canvases.GameCanvas.DescriptionCanvas.WordArea = "Area";
        _canvases.GameCanvas.DescriptionCanvas.WordTimeSpent = "Residence period";
        _canvases.GameCanvas.DescriptionCanvas.WordFoodSupplies = "Food stocks for";
        _canvases.GameCanvas.DescriptionCanvas.WordLocation = "Location ";
        _canvases.GameCanvas.DescriptionCanvas.WordResources = "Resources";
        _canvases.GameCanvas.DescriptionCanvas.WordPremises = "Premises";
        _canvases.GameCanvas.DescriptionCanvas.WordYear = "year";
        _canvases.GameCanvas.DescriptionCanvas.WordYears = "years";
        _canvases.GameCanvas.DescriptionCanvas.WordYearsForRussian = null;
        _canvases.GameCanvas.DescriptionCanvas.WordMonth = "month";
        _canvases.GameCanvas.DescriptionCanvas.WordMonths = "months";
        _canvases.GameCanvas.DescriptionCanvas.WordMonthsForRussian = null;
        _canvases.GameCanvas.DescriptionCanvas.WordNumberPlaces = "Number of seats";
        #endregion
        #region User Canvas
        #endregion
        #region Users Canvas
        _canvases.GameCanvas.UsersCanvas.Users.text = "PLAYERS";
        #endregion
        #endregion

        _canvases.GameCanvas.UserCanvas.TranslateKeywords = new Dictionary<string, string>
        {
            {  Keys.Profession, "Profession" },
            {  Keys.Skills, "Skill" },
            {  Keys.Sex, "Sex" },
            {  Keys.Age, "����Age���" },
            {  Keys.SexualOrientation, "Sexual orientation" },
            {  Keys.Health, "Health" },
            {  Keys.Hobby, "Hobby" },
            {  Keys.CharacterTraits, "Character traits" },
            {  Keys.Phobia, "Phobia" },
            {  Keys.Additionally, "Additionally" },
            {  Keys.SmallLuggage, "Small luggage" },
            {  Keys.BigLuggage, "Big luggage" },

        };

        _data.SetData = new Dictionary<string, DataParams>
        {
            {
                "Profession", new DataParams
                {
                    Text = new List<string>
                    {
                        "Applicant", "Auto mechanic", "Agronomist", "Lawyer", "Actor / Actress",
                        "Bartender", "Businessman", "Botanist", "Bookmaker", "Driller", "Accountant", "Watchman", "Veterinarian",
                        "Winemaker", "Miron", "Virologist", "Serviceman", "Thief", "Prostitute", "Gamer", "Genetician", "Geographer", "Maid",
                        "Trucker", "Taster", "Diplomat", "Doctor", "Milkmaid", "Jockey", "Inventor", "Engineer", "Hookah Man", "Film Director",
                        "Clown", "Collector", "Lieutenant", "Butcher", "Drug lord", "Oncologist", "Brewer", "Cook", "Porn actor", "Programmer",
                        "Foreman", "Streamer", "Builder", "Judge", "Sushist", "Tractor Driver", "Pharmacist", "Hacker", "Economist", "Lawyer", "Nikita"
                    }
                }
            },
            {
                "Skills", new DataParams
                {
                    Skill = new List<Skill>
                    {

                        new Skill { FirstSkill = "Can change his profession to a random one if he is at least 18 or older than 27. Otherwise he becomes a Soldier.", SecondSkill = "Can go without food for two weeks."},
                        new Skill { FirstSkill = "Knows where the workshop is.", },
                        new Skill { FirstSkill = "Adds a crate of groceries to your inventory.", },
                        new Skill { FirstSkill = "Once per game, can redirect a vote to yourself that was against some player.", },
                        new Skill { FirstSkill = "Can use any player's profession ability.", },
                        new Skill { FirstSkill = "Once per game can add the health condition �Alcoholism (mild)� to any player.", },
                        new Skill { FirstSkill = "Can take the exiled player's open inventory.", },
                        new Skill { FirstSkill = "Adds any plant seeds to your inventory.", },
                        new Skill { FirstSkill = "Can swap two players' hobbies.", },
                        new Skill { FirstSkill = "Adds a drill with a full charge to your inventory (the charge is enough for 24 hours of active work).", },
                        new Skill { FirstSkill = "Can change the amount of food in the bunker from \"lack\" to \"too much\" and vice versa.", },
                        new Skill { FirstSkill = "Adds a safe to your inventory.", },
                        new Skill { FirstSkill = "Adds any animal to inventory (up to 50 kg.)", },
                        new Skill { FirstSkill = "When it enters the bunker, it will carry a case of wine with it.", },
                        new Skill { FirstSkill = "Once per game can learn all information about any person", },
                        new Skill { FirstSkill = "Adds 1 Universal Vaccine against Airborne Infections to inventory.", },
                        new Skill { FirstSkill = "Adds a pistol and 28 bullets to inventory", },
                        new Skill { FirstSkill = "Can steal another player's inventory.", },
                        new Skill { FirstSkill = "Can heal anyone once per game", },
                        new Skill { FirstSkill = "Been through all the survival games and knows a couple of valuable tips on how to survive in an extreme situation.", },
                        new Skill { FirstSkill = "Greatly increases the chance of having healthy babies when hit in a bunker.", },
                        new Skill { FirstSkill = "Adds a terrain map to your inventory.", },
                        new Skill { FirstSkill = "Adds a disinfection kit to your inventory.", },
                        new Skill { FirstSkill = "Adds a stack of porn magazines to your inventory.", },
                        new Skill { FirstSkill = "Immune to alcohol-related phobias and diseases. Adds 10 liters of any drink to your inventory.", },
                        new Skill { FirstSkill = "At will, can cancel a friend's or enemy's card if one is directed at him.", },
                        new Skill { FirstSkill = "Once per game, can cure any \"mild\" or \"moderate\" disease to any player other than himself.", },
                        new Skill { FirstSkill = "Adds a cow to your inventory.", },
                        new Skill { FirstSkill = "Adds a horse to your inventory.", },
                        new Skill { FirstSkill = "When you hit the bunker, an automatic egg incubator will appear in your inventory.", },
                        new Skill { FirstSkill = "When entering the bunker, it adds an equipped hookah room. The size of the bunker does not change.", },
                        new Skill { FirstSkill = "Can regenerate the \"Add. information\".", },
                        new Skill { FirstSkill = "Can change skills clockwise. Works once per game.", },
                        new Skill { FirstSkill = "Can steal inventory from any player.", },
                        new Skill { FirstSkill = "����� ������� ��������� � ������ ������.",  },
                        new Skill { FirstSkill = "May remove 1 downvote when voting."},
                        new Skill { FirstSkill = "Adds 5kg of raw smoked meat to your inventory."},
                        new Skill { FirstSkill = "Adds 2 sachets (100g each) of the same herbs for depression to any player's inventory."},
                        new Skill { FirstSkill = "Can reduce cancer disease to Mild (once per game).\n* Cannot be cast on a player whose disease is \"Critical\".\n* Cannot be cured."} ,
                        new Skill { FirstSkill = "Adds 10 pack of Doshirak to your inventory."},
                        new Skill { FirstSkill = "Has the ability to heal childfree of the opposite sex."},
                        new Skill { FirstSkill = "Can regenerate any player's skill except himself."},
                        new Skill { FirstSkill = "Can split any room in the bunker into 2 rooms."},
                        new Skill { FirstSkill = "Can unlock an additional stat on your turn (once per game)."},
                        new Skill { FirstSkill = "Adds any room to the bunker. The size of the bunker does not change."},
                        new Skill { FirstSkill = "If the players got an equal number of votes during the voting, it can decide who to kick. The decision can be made once per game."},
                        new Skill { FirstSkill = "Adds 2kg of sushi to inventory."},
                        new Skill { FirstSkill = "Can say \"300\" and get 2kg of grain in inventory."},
                        new Skill { FirstSkill = "Knows the location of the medical supply store."},
                        new Skill { FirstSkill = "Adds a laptop with a charger to your inventory."},
                        new Skill { FirstSkill = "Able to calculate the amount of food in such a way that it will last for 1 more month."},
                        new Skill { FirstSkill = "Can decide (regardless of other players' opinions) whether to vote in a round or skip voting."},
                        new Skill { FirstSkill = "Player turns into a bear and kills one player (optional)"},
                    }
                }
            },
            {
                "SecondSkill", new DataParams
                {
                    Text = new List<string>
                    {
                        "Adds one place to the bunker", "Allows you to cure any disease of any player except you", "The player opposite you must not enter the bunker", "Removes snakes from the bunker", "Protects any player for one turn (except you)" ,
                        "There is an armory near the bunker", "Any player chooses to reveal his hobby", "Allows you to learn another player's hobby", "The player to your left must get into the bunker", "The bunker is in the forest",
                        "There is a bunker near you with two female chemists (Full health / age: 25-45 years old)", "Allows you to exchange phobias with another player", "There is a tank near the bunker", "Removes spiders from the bunker",
                        "Allows you to activate map number 2 of the player of your choice", "adds spiders to the bunker", "Everyone will know that the bunker is on a desert island",
                        "Exchange professions from left to right", "There is a bunker with aggressive survivors near you", "You can exchange health with another player",
                        "You can change professions with another player", "Clears a place from the bunker", "There is a bunker near you with all the brazzers actresses (Fully healthy / age: 20-45 years old);"
                    }
                }
            },
            {
                "Sex", new DataParams
                {
                    Text = new List<string>
                    {
                        "Man", "Woman"
                    }
                }
            },
            {
                "Age", new DataParams
                {

                }
            },
            {
                "SexualOrientation", new DataParams
                {
                    Text = new List<string>
                    {
                       "Heterosexual", "Gay", "Lesbian", "Bisexual", "Queer (Weird)", "Asexual", "Aromantic", "Androsexual", "Gynosexual", "Demisexual", "Pansexual", "Transvestite"
                    }
                }
            },
            {
                "Health", new DataParams
                {
                    Text = new List<string>
                    {
                        "Perfectly healthy", $"Cancer {Random.Range(1, 5)} degrees", "Drug addict", "One eye to the Caucasus, the other to Arzamas (strabismus)", "Tuberculosis", "Heartburn", "Rabies" , "Colorblind", "Scoliosis",
                         "Schizo", "Hepatitis B", "HIV", "Covid-19", "Delirium", "Psychosis", "Flatfoot", "Crystal Man Syndrome", "Rickets", "Bulimia", $"AIDS (Will Die in {Random.Range(2, 4)} years", "Generally healthy",
                         "Hemorrhoids", "Alzheimer's", "Breast Cancer", "Mild Alcoholism", "Blood Cancer (will die in a year)", "Diabetes", "Acne", "Legless", "Armless", "Mute"," Paranoia"
                    }
                }
            },
            {
                "Hobby", new DataParams
                {
                    Text = new List<string>
                    {
                        "Collects bugs and spiders", "Spends time with birds", "Trainsurfing", "Collecting beer can rings", "Hacking terminals", "Dancing", "War games", "Cartography", "Cooking", "Shoot guns",
                        "Photographer", "Drinking Beer", "Skydiving", "Rock Climbing", "Streetluge", "Motorcycle Ride", "Passing Couples", "Soap Making", "Weapon Making", "Bodybuilding & Weightlifting",
                        "Growing Plants", "Beer Brewing", "Cheese Making", "Tea Drinking", "Eating Fly Agaric", "Search for a Bookmark", "Earning as a Taxi Driver (I Have My Own Business)", "Pick-up Drinking", "Archery", "Boxing ", "To breed animals",
                        "Programming", "Participation in charitable and socially significant projects", "Gardening", "masturbation", "Martial arts", "Historical reconstructions", "Card games", "Tennis", "Building design"
                    }
                }
            },
            {
                "CharacterTraits", new DataParams
                {
                    Text = new List<string>
                    {
                        "Kindness", "Honesty", "Loyalty", "Responsiveness", "Generosity", "Humor", "Accuracy", "Fearlessness", "Active", "Wise", "Semperature", "Observant", "Optimist", "Luck", "Responsiveness",
                        "Romantic", "Persistent", "Punctuality", "Correction", "Calm", "Industriousness", "Sense of Duty", "Enthusiasm", "Elegance", "Economy", "Persistence", "Perseverance", "openness", "sociability",
                        "Harmful", "Grumbling", "Seclusion", "Laziness", "Hypocrisy", "Unsociable", "Persistence", "Courage", "Wisdom", "Selfishness", "Irritability", "Passivity", "Greed", "Tolerance", "Calm"
                    }
                }
            },
            {
                "Phobia", new DataParams
                {
                    Text = new List<string>()
                    {
                        "No", "Selachophobia - fear of sharks", "Nosophobia - fear of disease", "Algophobia - fear of pain", "Brontophobia - fear of thunder", "Ripophobia - fear of dirt", "Claustrophobia", "Eisoptrophobia - fear of mirrors", "Ophidiophobia - fear of snakes",
                        "Arachnophobia - fear of spiders", "Thanatophobia - fear of death", "Achluophobia - fear of the dark", "Aetatemophobia - fear of aging", "Carcinomatophobia - fear of cancer", "Skelerophobia - fear of bad people",
                        "katagelophobia - fear of ridicule", "Aichmophobia - sharp objects", "Dysmorphophobia - fear of physical defects", "Aquaphobia - fear of drowning", "Trypanophobia - fear of injections", "Pnigophobia - fear of strangulation",
                        "Necrophobia - fear of corpses", "Iatrophobia - fear of doctors", "Acrophobia - fear of heights", "Glossophobia - fear of speaking in public", "Sociophobia", "Pyrophobia - fear of fire",
                        "Eremophobia - fear of loneliness", "Katagelophobia - fear of ridicule", "Spermophobia - fear of microbes", "Dentophobia - fear of dentists", "Hematophobia - fear of blood", "Rodentophobia - fear of rats",
                        "Gravidophobia - fear of meeting with a pregnant pregnancy"
                    }
                }
            },
            {
                "Additionally", new DataParams
                {
                    Text = new List<string>
                    {
                        "Accurate", "well versed in higher mathematics", "Jew", "Negro", "He got hit by a bream", "Has psychic abilities", "Knows where the supplies of seeds per hectare are",
                        "Knows where food supplies are for two months", "Founder of CBD", "Good with animals", "Disabled", "Knows how to juggle", "Took hairdresser's course",
                        "Hates modern music", "Survived three assassination attempts", "Has a phenomenal memory", "Nobel laureate", "No", "Hates men", "Communist", "Knows his name",
                        "Knows how to breathe", "Knows how to use a pen", "Knows how to open canned food", "This catastrophe is a conspiracy of reptiles", "Believes in aliens", "Schizik", "Believes in God", "Believes in the Devil", "He is fond of hunting",
                        "Read a book about survival on a desert island", "Suffers from seasickness", "Designed this bunker", "May be able to provide first aid", "Took a cooking course", "Coprofil",
                        "The founder of the blue moon", "Owns an anti-cafe", "Can light raw firewood", "Escaped from prison", "Won all school quests", "Friends with Timati. Popped a burger for the health of a sobyanin", "Survival expert",
                        "Advertised the LDPR Party", "Knows how to cook bugs", "Has 4 million followers on Instagram", "Once drank the blue lord", "Makes delicious potato pancakes"
                    }
                }
            },
            {
                "SmallLuggage", new DataParams
                {
                    Text = new List<string>
                    {
                        "Feathers", "Bandages", "Pincent", "Phone", "Cookware set", "Gun", "A year's supply of pasta", "Watch", "Empty cardboard box", "Soap", "Rope", " Baton", "Flashlight and spare batteries",
                        "Kitchen tool set", "Vibrator", "Security camera", $"Porn magazines ({Random.Range(1, 8)} pcs)", "Pen", "ABC", "Wireless speaker", "Lipple "," Gum (mint)",
                        $"Strip test ({Random.Range(1, 4)} pcs)", "Shavers", "Water bottle (5gallon)", "Mirror", "Traps", "Meals for one week", " Tweezers", "Alarm Clock", "Manicure Book", "Georgian Tea", "Indian Tea",
                        "Four walkie-talkies", "Needle and thread", "US flag", "Flint", "Battery", "Backpack", "Compass", "Cast-iron utensils", "Used syringe", "Photograph of the earth from space", " condoms",
                        "Spider", "Turtle", "Toys", "Crowbar", "Shovel", "Grenade", "Suitcase", "Poker", "Joystick", "Passport", "Morse code book", "Persian cat "," Cartridges for a pistol (24 pcs)", "Two cans of beer",
                        "Vodka bottle", "Ten disposable medical masks", "Red diploma", "Telephone", "Potato seeds", "Hammer and nails", "Iron pipe", "Sunglasses", "A ring with a diamond",
                        "Tool set", "Kidney"

                    }
                }
            },
            {
                "BigLuggage", new DataParams
                {
                    Text = new List<string>
                    {
                        "A year's supply of pasta", "Fire extinguisher", "Engine", "Generator", "Cow with food for 3 months", "Bicycle", "Axe", "Roll of toilet paper (100 m)", "Ambulance paramedic kit ",
                        "Lego car constructor for 521 parts", "Board games (3 pcs)", "Assault rifle with 3 horns", "RZK suit (2 pcs)", "Role-playing game suit", "Building set", "Radio station ", "German Shepherd",
                        "Meals for one month", "TV", "Sleeping bags", "Drawing", "Window", "Operation kit", "Air freshener packaging", "Cash register", "A4 white paper packaging",
                        "Refrigerator", "Toilet", "Coffin", "Trampoline", "Door", "Wheel from Belaz", "Penguin", "C4", "Vacuum cleaner", "Lawn mower", "Tractor", "Chair with peaks chiseled", "Two cows", "Ferret", "Cat", "Dog"
                    }
                }
            },
            {
                "BunkerName", new DataParams
                {
                    Text = new List<string>
                    {
                        "77", "Nemo", "Alpha", "1771", "Ob. 99", "Lengov", "Armata", "VVO", "ATUB", "Gintor", "Nevs", "Beta", "Gamma", "Delta", "Lambda", "Early 997", "Werewolf",
                    }
                }
            },
            {
                "BunkerPlace", new DataParams
                {
                    Text = new List<string>
                    {
                        "Desert", "Reserve", "Forest", "Desert Island", "City", "Tropics", "Mountains", "Village", "Slums", "Field", "Tundra", "Baikal", "Forest", "Marshland", "Planktation", "Werewolf",
                    }
                }
            },
            {
                "BunkerArea", new DataParams
                {
                    Text = new List<string>
                    {
                        "47", "100", "89", "55", "170", "139", "350", "320", "120", "80", "300", "187", "145", "200", "250", "240", "129", "192", "77", "215"
                    }
                }
            },
            {
                "BunkerResources", new DataParams
                {
                    Text = new List<string>
                    {
                        "First aid kit", "Winter clothes", "First aid kit", "Instruction for survival in the forest", "Radio;", "Tool kit", "Drums", "Soft toys", "First aid kit",
                        "Moonshine still", "Broken generator", "Generator with gasoline", "A set of dry rations", "A set of tomato soups", "Water supply", "Checkers", "Chess", "Flashlight", "Axe",
                        "Playing Cards", $"Rifle with {Random.Range(1, 9)} clip", "Bong", "Suitcase with Clothes", "Flashlight", "Area Map", "Rat Poison", " Tuba", "Guitar", "First Aid Kit",
                        "Snus", "Bayan", "Table lamp", "Cosmetic bag", "Tutorial on how to survive in a bunker", "Winter clothes", "Wetsuit with an air tank"
                    }
                }
            },
            {
                "BunkerBuildings", new DataParams
                {
                    Text = new List<string>
                    {
                        "Greenhouse", "Broken Greenhouse", "Office Room", "Dining Room", "Chemical Lab", "Provision Warehouse", "Research Lab", "Barbershop", "Empty Warehouse", "Shower Room",
                        "Generator with gasoline", "Workshop with tools", "Medical office", "Radio station", "Gym", "Assembly hall (with stage)", "Room with a lathe",
                        "Meth Lab", "Weapons Depot", "Basement", "Room Full of Hentai Comics", "Prepared Operating Room", "Moonshine Still", "Information Technology Room",
                        "Disguised Surface Observation Tube", "Destroyed Medical Room", "Crowded Armory", "Several Bedrooms", "Broken Chem Lab", "Greenhouse",
                        "Destroyed Greenhouse", "Landed Greenhouse", $"Landed Bedroom with {Random.Range(1, 7)} bed", "Empty Room"
                    }
                }
            }
        };
    }
}
