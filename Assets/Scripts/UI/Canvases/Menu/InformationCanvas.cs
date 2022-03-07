using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InformationCanvas : MonoBehaviour
{
    public TMP_Text Title;
    public TMP_Text Subtitle;
    public TMP_Text PlotTitle;
    public TMP_Text PlotDescription;
    public TMP_Text PurposeOfTheGameTitle;
    public TMP_Text PurposeOfTheGameDescription;
    public TMP_Text RulesOfTheGameTitle;
    public TMP_Text RulesOfTheGameDescription;

    private Canvases _canvases;

    public void Initialize(Canvases canvases)
    {
        _canvases = canvases;
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
