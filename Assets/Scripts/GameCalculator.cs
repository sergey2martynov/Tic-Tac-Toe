using System;
using System.Collections.Generic;
using UnityEngine;

public class GameCalculator : MonoBehaviour
{
    [SerializeField] private List<FieldClickController> _fields;

    [SerializeField] public List<FieldValue> _fieldValues;

    [SerializeField] private MoveCounter _moveCounter;

    [SerializeField] private TextOutput _textOutput;

    private VictoryDetector _victoryDetector;

    public GameState GameStates { get; set; }

    public event Action PlayerMoved;

    private void Awake()
    {
        GameStates = GameState.Game;

        _victoryDetector = new VictoryDetector();

        foreach (var field in _fields)
        {
            field.FieldClicked += SetCrossInField;
        }
    }

    private void SetCrossInField(int numberField)
    {
        _fieldValues[numberField] = FieldValue.Cross;

        GameStates =
            _victoryDetector.CheckVictoryPlayers(_fieldValues, _textOutput, FieldValue.Cross, GameState.CrossesWin);

        _moveCounter.IncreaseCount();

        PlayerMoved?.Invoke();
    }
}