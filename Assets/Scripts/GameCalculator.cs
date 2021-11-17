using System;
using System.Collections.Generic;
using UnityEngine;

public class GameCalculator : MonoBehaviour
{
    [SerializeField] private List<FieldsClickController> _field;

    [SerializeField] public List<FieldValue> _fieldValues;
    
    [SerializeField] private CrossesVictoryDetector _crossesVictoryDetector;
    
    [SerializeField] private CountManager _countManager;

   public GameStates _gameStates;

    public event Action MovePlayer;

    private void Awake()
    {
        _gameStates = GameStates.Game;
        
        foreach (var field in _field)
        {
            field.FieldClicked += SetCrossInField;
        }
    }

    private void SetCrossInField(int numberField)
    {
        _fieldValues[numberField] = FieldValue.Cross;
        
        _crossesVictoryDetector.СheckVictoryCrosses();
        
        _countManager.AddOneCounter();
        
        MovePlayer?.Invoke();
    }
}