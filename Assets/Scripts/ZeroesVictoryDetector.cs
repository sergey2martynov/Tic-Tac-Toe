using System;
using UnityEngine;

public class ZeroesVictoryDetector : MonoBehaviour
{
    [SerializeField] private GameCalculator _gameCalculator;

    [SerializeField] private TextManager _textManager;

    public void СheckVictoryZeroes()
    {
        if (_gameCalculator._fieldValues[0] == FieldValue.Zero &&
            _gameCalculator._fieldValues[1] == FieldValue.Zero &&
            _gameCalculator._fieldValues[2] == FieldValue.Zero ||
            _gameCalculator._fieldValues[3] == FieldValue.Zero &&
            _gameCalculator._fieldValues[4] == FieldValue.Zero &&
            _gameCalculator._fieldValues[5] == FieldValue.Zero ||
            _gameCalculator._fieldValues[6] == FieldValue.Zero &&
            _gameCalculator._fieldValues[7] == FieldValue.Zero &&
            _gameCalculator._fieldValues[8] == FieldValue.Zero ||
            _gameCalculator._fieldValues[0] == FieldValue.Zero &&
            _gameCalculator._fieldValues[3] == FieldValue.Zero &&
            _gameCalculator._fieldValues[6] == FieldValue.Zero ||
            _gameCalculator._fieldValues[1] == FieldValue.Zero &&
            _gameCalculator._fieldValues[4] == FieldValue.Zero &&
            _gameCalculator._fieldValues[7] == FieldValue.Zero ||
            _gameCalculator._fieldValues[2] == FieldValue.Zero &&
            _gameCalculator._fieldValues[5] == FieldValue.Zero &&
            _gameCalculator._fieldValues[8] == FieldValue.Zero ||
            _gameCalculator._fieldValues[6] == FieldValue.Zero &&
            _gameCalculator._fieldValues[4] == FieldValue.Zero &&
            _gameCalculator._fieldValues[2] == FieldValue.Zero ||
            _gameCalculator._fieldValues[0] == FieldValue.Zero &&
            _gameCalculator._fieldValues[4] == FieldValue.Zero &&
            _gameCalculator._fieldValues[8] == FieldValue.Zero)
        {
            _gameCalculator._gameStates = GameStates.ZerosWin;
            
            _textManager._result.text = Enum.GetName(typeof(GameStates), 1);

            _textManager.ShowTextOfZeroes();
        }
    }
}