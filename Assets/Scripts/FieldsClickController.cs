using System;
using UnityEngine;
public class FieldsClickController : MonoBehaviour
{
    
    [SerializeField] private GameObject _cross;

    [SerializeField] public int _numberField;

    [SerializeField] private GameCalculator _gameCalculator;

    public event Action<int> FieldClicked;

    private void OnMouseUp()
    {
        if (_gameCalculator._fieldValues[_numberField] == FieldValue.Empty)
        {
            FieldClicked?.Invoke(_numberField);
        
            _cross.SetActive(true);
        }
    }
}
