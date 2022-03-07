using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutCanvas : MonoBehaviour
{
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
