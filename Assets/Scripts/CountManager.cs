using System;
using UnityEngine;

public class CountManager : MonoBehaviour
{
    [SerializeField] public int _count;
    
    [SerializeField] private TextManager _textManager;

    [SerializeField] private GameCalculator _gameCalculator;

    public void AddOneCounter()
    {
        _count++;

        if (_count == 9 && _gameCalculator._gameStates == GameStates.Game)
            
        {
            _textManager._result.text = Enum.GetName(typeof(GameStates), 2);
            
            _textManager.ShowTextOfDraw();
        }
    }
}
