using UnityEngine;

public class RestMovesOpponent : MonoBehaviour
{
    [SerializeField] private GameCalculator _gameCalculator;

    [SerializeField] private MoveOpponent _moveOpponent;

    [SerializeField] private CountManager _countManager;

    public void GoRestMoves()
    {
        if (_gameCalculator._gameStates != GameStates.Game)
        {
            return;
        }

        int numberField;

        if (CheckCornerField(new[] {0, 1, 8, 5, 6, 4, 2}, FieldValue.Zero))
        {
            numberField = 2;

            GoToField(numberField);
        }
        else if (CheckCornerField(new[] {6, 3, 1, 2, 4, 8, 0}, FieldValue.Zero))
        {
            numberField = 0;

            GoToField(numberField);
        }
        else if (CheckCornerField(new[] {3, 0, 7, 8, 4, 2, 6}, FieldValue.Zero))
        {
            numberField = 6;

            GoToField(numberField);
        }
        else if (CheckCornerField(new[] {6, 7, 5, 2, 4, 0, 8}, FieldValue.Zero))
        {
            numberField = 8;

            GoToField(numberField);
        }
        else if (CheckIntermediateField(new[] {4, 7, 0, 2, 1}, FieldValue.Zero))
        {
            numberField = 1;

            GoToField(numberField);
        }
        else if (CheckIntermediateField(new[] {3, 4, 8, 2, 5}, FieldValue.Zero))
        {
            numberField = 5;

            GoToField(numberField);
        }
        else if (CheckIntermediateField(new[] {4, 5, 6, 0, 3}, FieldValue.Zero))
        {
            numberField = 3;

            GoToField(numberField);
        }
        else if (CheckIntermediateField(new[] {1, 4, 6, 8, 7}, FieldValue.Zero))
        {
            numberField = 7;

            GoToField(numberField);
        }

        else if (CheckCornerField(new[] {0, 1, 8, 5, 6, 4, 2}, FieldValue.Cross))
        {
            numberField = 2;

            GoToField(numberField);
        }
        else if (CheckCornerField(new[] {6, 3, 1, 2, 4, 8, 0}, FieldValue.Cross))
        {
            numberField = 0;

            GoToField(numberField);
        }
        else if (CheckCornerField(new[] {3, 0, 7, 8, 4, 2, 6}, FieldValue.Cross))
        {
            numberField = 6;

            GoToField(numberField);
        }
        else if (CheckCornerField(new[] {6, 7, 5, 2, 4, 0, 8}, FieldValue.Cross))
        {
            numberField = 8;

            GoToField(numberField);
        }
        else if (CheckIntermediateField(new[] {4, 7, 0, 2, 1}, FieldValue.Cross))
        {
            numberField = 1;

            GoToField(numberField);
        }
        else if (CheckIntermediateField(new[] {3, 4, 8, 2, 5}, FieldValue.Cross))
        {
            numberField = 5;

            GoToField(numberField);
        }
        else if (CheckIntermediateField(new[] {4, 5, 6, 0, 3}, FieldValue.Cross))
        {
            numberField = 3;

            GoToField(numberField);
        }
        else if (CheckIntermediateField(new[] {1, 4, 6, 8, 7}, FieldValue.Cross))
        {
            numberField = 7;

            GoToField(numberField);
        }
        else
        {
            for (int numbersField = 0; numbersField < 9; numbersField++)
            {
                if (_gameCalculator._fieldValues[numbersField] != FieldValue.Empty) continue;
                GoToField(numbersField);
                return;
            }
        }
    }

    private void GoToField(int numberField)
    {
        _gameCalculator._fieldValues[numberField] = FieldValue.Zero;

        _moveOpponent._zero[numberField].SetActive(true);

        _countManager.AddOneCounter();
    }

    private bool CheckIntermediateField(int[] numbers, FieldValue fieldValue)
    {
        return (_gameCalculator._fieldValues[numbers[0]] == fieldValue &&
                _gameCalculator._fieldValues[numbers[1]] == fieldValue ||
                _gameCalculator._fieldValues[numbers[2]] == fieldValue &&
                _gameCalculator._fieldValues[numbers[3]] == fieldValue) &&
               _gameCalculator._fieldValues[numbers[4]] == FieldValue.Empty;
    }

    private bool CheckCornerField(int[] numbers, FieldValue fieldValue)
    {
        return (_gameCalculator._fieldValues[numbers[0]] == fieldValue &&
                _gameCalculator._fieldValues[numbers[1]] == fieldValue ||
                _gameCalculator._fieldValues[numbers[2]] == fieldValue &&
                _gameCalculator._fieldValues[numbers[3]] == fieldValue ||
                _gameCalculator._fieldValues[numbers[4]] == fieldValue &&
                _gameCalculator._fieldValues[numbers[5]] == fieldValue) &&
               _gameCalculator._fieldValues[numbers[6]] == FieldValue.Empty;
    }
}