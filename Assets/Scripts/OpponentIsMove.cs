using System.Collections.Generic;
using UnityEngine;

public class OpponentIsMove : MonoBehaviour
{
    [SerializeField] private GameCalculator _gameCalculator;

    [SerializeField] public List<GameObject> _zeroes;

    [SerializeField] private MoveCounter _moveCounter;

    [SerializeField] private TextOutput _textOutput;

    private VictoryDetector _victoryDetector;
    private OpponentIsFirstMove _opponentIsFirstMove;
    private RestMovesOpponent _restMoveOpponent;

    private void Start()
    {
        _victoryDetector = new VictoryDetector();

        _opponentIsFirstMove = new OpponentIsFirstMove();

        _restMoveOpponent = new RestMovesOpponent();

        _gameCalculator.PlayerMoved += GoOpponent;
    }

    private void GoOpponent()
    {
        if (_moveCounter.Count == 1)
        {
            _opponentIsFirstMove.GoFirstTime(_gameCalculator, _zeroes, _moveCounter);
        }
        else
        {
            _restMoveOpponent.GoRestMoves(_gameCalculator, _zeroes, _moveCounter);
        }

        _gameCalculator.GameStates = _victoryDetector.CheckVictoryPlayers(_gameCalculator._fieldValues, _textOutput,
            FieldValue.Zero, GameState.ZeroesWin);
    }
}