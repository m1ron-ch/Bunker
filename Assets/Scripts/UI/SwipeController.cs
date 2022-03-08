using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    [SerializeField] private List<Vector3> _canvasPositions = new List<Vector3>();
    [SerializeField] private Canvases _canvases;
    [SerializeField] private GameObject _gameCanvases;
    [SerializeField] private int _totalPages = 1;
    [SerializeField] private int _currentPage = 1;

    private Vector2 _startPosition;
    private float _percentThreshold = 0.25f;
    private float _easing = 0.32f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                _startPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
/*                if(_gameCanvases.transform.localPosition.x > 0 || _gameCanvases.transform.localPosition.x < -1972)
                {
                    return;
                }
                float diffrenes = _startPosition.x - touch.position.x;
                _gameCanvases.transform.position -= new Vector3(diffrenes, 0, 0) * 0.01f * Time.deltaTime;*/
            }
            else if(touch.phase == TouchPhase.Ended)
            {
                float percentage = (_startPosition.x - touch.position.x) / Screen.width;
                if (Mathf.Abs(percentage) >= _percentThreshold)
                {
                    Vector3 newLocation;
                    if (percentage > 0 && _currentPage < _totalPages)
                    {
                        _currentPage++;
                        newLocation = _canvasPositions[_currentPage - 1];
                        StartCoroutine(SmoothMove(_gameCanvases.transform.localPosition, newLocation, _easing));
                    }
                    else if (percentage < 0 && _currentPage > 1)
                    {
                        _currentPage--;
                        newLocation = _canvasPositions[_currentPage - 1];
                        StartCoroutine(SmoothMove(_gameCanvases.transform.localPosition, newLocation, _easing));
                    }
                }
                else
                {
                    StartCoroutine(SmoothMove(_gameCanvases.transform.localPosition, _canvasPositions[_currentPage - 1], _easing));
                }
            }
        }
    }

    private IEnumerator SmoothMove(Vector3 startPos, Vector3 endPos, float seconds)
    {
        float t = 0f;
        while (t <= 1.0)
        {
            t += Time.deltaTime / seconds;
            _gameCanvases.transform.localPosition = Vector3.Slerp(startPos, endPos, Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }
    }
}
