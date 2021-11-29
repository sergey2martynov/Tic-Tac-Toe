using UnityEngine;

public class DrawDetector : MonoBehaviour
{
    [SerializeField] private GameCalculator _gameCalculator;

    [SerializeField] private TextOutput _textOutput;

    [SerializeField] private MoveCounter _moveCounter;

    public const int NumberOfMove = 9;

    public void СheckForADraw()
    {
        if (_moveCounter.Count != NumberOfMove || _gameCalculator.GameStates != GameState.Game) return;
        _gameCalculator.GameStates = GameState.Draw;

        _textOutput.ShowTextOfWinner(GameState.Draw);
    }
}