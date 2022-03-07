using UnityEngine;


public class MenuCanvas : MonoBehaviour
{
    [SerializeField] private MainMenuCanvas _mainMenuCanvas;
    [SerializeField] private SettingsCanvas _settingsCanvas;
    [SerializeField] private InformationCanvas _informationCanvas;
    [SerializeField] private AboutCanvas _aboutCanvas;

    private Canvases _canvases;

    public MainMenuCanvas MainMenuCanvas { get { return _mainMenuCanvas; } }
    public SettingsCanvas SettingsCanvas { get { return _settingsCanvas; } }
    public InformationCanvas InformationCanvas { get { return _informationCanvas; } }
    public AboutCanvas AboutCanvas { get { return _aboutCanvas; } }

    private void Start()
    {
        _mainMenuCanvas.Initialize(_canvases);
        _informationCanvas.Initialize(_canvases);
        _settingsCanvas.Initialize(_canvases);
        _aboutCanvas.Initialize(_canvases);
    }

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
