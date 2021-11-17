using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] public GameObject _resultText;
    
    [SerializeField] public GameObject _panel;
    
    [SerializeField] public GameObject _smallPanel;
    
    [SerializeField] public TextMeshProUGUI _result;

    [SerializeField] private Color _colorTextWinCrosses;
    
    [SerializeField] private Color _colorPanelWinCrosses;
    
    [SerializeField] private Color _colorTextWinZeroes;
    
    [SerializeField] private Color _colorPanelWinZeroes;
    
    [SerializeField] private Color _colorTextDraw;
    
    [SerializeField] private Color _colorPanelDraw;
    
    [SerializeField] private Graphic _graphicPanel;
    
    [SerializeField] private Graphic _graphicText;

    public event Action GameOver;

    public void Start()
    {
        _resultText.SetActive(false);
        
        _panel.SetActive(false);
        
        _smallPanel.SetActive(false);
    }

    public void ShowTextOfCrosses()
    {
        _graphicPanel.color = _colorPanelWinCrosses;
        
        _graphicText.color = _colorTextWinCrosses;
        
        _resultText.SetActive(true);
        
        _panel.SetActive(true);
        
        _smallPanel.SetActive(true);
        
        GameOver?.Invoke();
    }

    public void ShowTextOfZeroes()
    {
        _graphicPanel.color = _colorPanelWinZeroes;
        
        _graphicText.color = _colorTextWinZeroes;
        
        _resultText.SetActive(true);
        
        _panel.SetActive(true);
        
        _smallPanel.SetActive(true);
        
        GameOver?.Invoke();
    }
    
    public void ShowTextOfDraw()
    {
        _graphicPanel.color = _colorPanelDraw;
        
        _graphicText.color = _colorTextDraw;
        
        _resultText.SetActive(true);
        
        _panel.SetActive(true);
        
        _smallPanel.SetActive(true);
        
        GameOver?.Invoke();
    }
}
