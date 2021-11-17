using UnityEngine;

public class FirstMoveOpponent : MonoBehaviour
{
    private RandomNumbers _myRandomNumber;

    [SerializeField] private GameCalculator _gameCalculator;

    [SerializeField] private MoveOpponent _moveOpponent;
    
    [SerializeField] private CountManager _countManager;

    private const int FieldNumberFour = 4;

    private void Start()
    {
        _myRandomNumber = new RandomNumbers();
    }

    public void GoFirstTime()
    {
        int numberField;

        if (_gameCalculator._fieldValues[FieldNumberFour] == FieldValue.Cross)
        {
            var randomAngularNumber = _myRandomNumber.RandomAngularNumber();

            _gameCalculator._fieldValues[randomAngularNumber] = FieldValue.Zero;

            numberField = randomAngularNumber;
        }
        else
        {
            _gameCalculator._fieldValues[FieldNumberFour] = FieldValue.Zero;

            numberField = FieldNumberFour;
        }

        _moveOpponent._zero[numberField].SetActive(true);
        
        _countManager.AddOneCounter();
    }
}