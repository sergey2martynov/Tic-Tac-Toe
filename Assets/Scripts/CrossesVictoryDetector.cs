using System;
using UnityEngine;

public class CrossesVictoryDetector : MonoBehaviour
{
    [SerializeField] private GameCalculator _gameCalculator;

    [SerializeField] private TextManager _textManager;

    public void СheckVictoryCrosses()
    {
        if (_gameCalculator._fieldValues[0] == FieldValue.Cross &&
            _gameCalculator._fieldValues[1] == FieldValue.Cross &&
            _gameCalculator._fieldValues[2] == FieldValue.Cross ||
            _gameCalculator._fieldValues[3] == FieldValue.Cross &&
            _gameCalculator._fieldValues[4] == FieldValue.Cross &&
            _gameCalculator._fieldValues[5] == FieldValue.Cross ||
            _gameCalculator._fieldValues[6] == FieldValue.Cross &&
            _gameCalculator._fieldValues[7] == FieldValue.Cross &&
            _gameCalculator._fieldValues[8] == FieldValue.Cross ||
            _gameCalculator._fieldValues[0] == FieldValue.Cross &&
            _gameCalculator._fieldValues[3] == FieldValue.Cross &&
            _gameCalculator._fieldValues[6] == FieldValue.Cross ||
            _gameCalculator._fieldValues[1] == FieldValue.Cross &&
            _gameCalculator._fieldValues[4] == FieldValue.Cross &&
            _gameCalculator._fieldValues[7] == FieldValue.Cross ||
            _gameCalculator._fieldValues[2] == FieldValue.Cross &&
            _gameCalculator._fieldValues[5] == FieldValue.Cross &&
            _gameCalculator._fieldValues[8] == FieldValue.Cross ||
            _gameCalculator._fieldValues[6] == FieldValue.Cross &&
            _gameCalculator._fieldValues[4] == FieldValue.Cross &&
            _gameCalculator._fieldValues[2] == FieldValue.Cross ||
            _gameCalculator._fieldValues[0] == FieldValue.Cross &&
            _gameCalculator._fieldValues[4] == FieldValue.Cross &&
            _gameCalculator._fieldValues[8] == FieldValue.Cross)
        {
            _gameCalculator._gameStates = GameStates.CrossesWin;
            
            _textManager._result.text = Enum.GetName(typeof(GameStates), 0);

            _textManager.ShowTextOfCrosses();
        }
    }
}