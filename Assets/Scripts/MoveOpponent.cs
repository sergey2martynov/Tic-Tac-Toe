using System.Collections.Generic;
using UnityEngine;

public class MoveOpponent : MonoBehaviour
{
    [SerializeField] private GameCalculator _gameCalculator;

    [SerializeField] public List<GameObject> _zero;
    
    [SerializeField] private FirstMoveOpponent _firstMoveOpponent;
    
    [SerializeField] private RestMovesOpponent _restMoveOpponent;

    [SerializeField] private ZeroesVictoryDetector _zeroesVictoryDetector;

    [SerializeField] private CountManager _countManager;

    private void Start()
    {
        _gameCalculator.MovePlayer += GoOpponent;
    }

    private void GoOpponent()
    {
        if (_countManager._count == 1)
        {
            _firstMoveOpponent.GoFirstTime();
        }
        else
        {
            _restMoveOpponent.GoRestMoves();
        }

        _zeroesVictoryDetector.СheckVictoryZeroes();
    }
}