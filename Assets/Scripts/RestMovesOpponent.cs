using System.Collections.Generic;
using UnityEngine;

public class RestMovesOpponent
{
    private const int VerificationNumber = 10;

    public void GoRestMoves(GameCalculator gameCalculator, List<GameObject> zeroes, MoveCounter moveCounter)
    {
        if (gameCalculator.GameStates != GameState.Game)
        {
            return;
        }

        if (!CheckFieldsWithValues(FieldValue.Zero, gameCalculator, zeroes, moveCounter))
        {
            if (!CheckFieldsWithValues(FieldValue.Cross, gameCalculator, zeroes, moveCounter))
            {
                for (int numbersField = 0; numbersField < 9; numbersField++)
                {
                    if (gameCalculator._fieldValues[numbersField] != FieldValue.Empty)
                    {
                        continue;
                    }

                    GoToField(numbersField, gameCalculator, zeroes, moveCounter);
                    return;
                }
            }
        }
    }

    private void GoToField(int numberField, GameCalculator gameCalculator, List<GameObject> zeroes,
        MoveCounter moveCounter)
    {
        gameCalculator._fieldValues[numberField] = FieldValue.Zero;

        zeroes[numberField].SetActive(true);

        moveCounter.IncreaseCount();
    }

    private bool CheckIntermediateField(int[] numbers, FieldValue fieldValue, GameCalculator gameCalculator)
    {
        return (gameCalculator._fieldValues[numbers[0]] == fieldValue &&
                gameCalculator._fieldValues[numbers[1]] == fieldValue ||
                gameCalculator._fieldValues[numbers[2]] == fieldValue &&
                gameCalculator._fieldValues[numbers[3]] == fieldValue) &&
               gameCalculator._fieldValues[numbers[4]] == FieldValue.Empty;
    }

    private bool CheckCornerField(int[] numbers, FieldValue fieldValue, GameCalculator gameCalculator)
    {
        return (gameCalculator._fieldValues[numbers[0]] == fieldValue &&
                gameCalculator._fieldValues[numbers[1]] == fieldValue ||
                gameCalculator._fieldValues[numbers[2]] == fieldValue &&
                gameCalculator._fieldValues[numbers[3]] == fieldValue ||
                gameCalculator._fieldValues[numbers[4]] == fieldValue &&
                gameCalculator._fieldValues[numbers[5]] == fieldValue) &&
               gameCalculator._fieldValues[numbers[6]] == FieldValue.Empty;
    }


    private bool CheckFieldsWithValues(FieldValue fieldValue, GameCalculator gameCalculator, List<GameObject> zeroes,
        MoveCounter moveCounter)
    {
        int numberField = VerificationNumber;
        if (CheckCornerField(new[] {0, 1, 8, 5, 6, 4, 2}, fieldValue, gameCalculator))
        {
            numberField = 2;

            GoToField(numberField, gameCalculator, zeroes, moveCounter);
        }
        else if (CheckCornerField(new[] {6, 3, 1, 2, 4, 8, 0}, fieldValue, gameCalculator))
        {
            numberField = 0;

            GoToField(numberField, gameCalculator, zeroes, moveCounter);
        }
        else if (CheckCornerField(new[] {3, 0, 7, 8, 4, 2, 6}, fieldValue, gameCalculator))
        {
            numberField = 6;

            GoToField(numberField, gameCalculator, zeroes, moveCounter);
        }
        else if (CheckCornerField(new[] {6, 7, 5, 2, 4, 0, 8}, fieldValue, gameCalculator))
        {
            numberField = 8;

            GoToField(numberField, gameCalculator, zeroes, moveCounter);
        }
        else if (CheckIntermediateField(new[] {4, 7, 0, 2, 1}, fieldValue, gameCalculator))
        {
            numberField = 1;

            GoToField(numberField, gameCalculator, zeroes, moveCounter);
        }
        else if (CheckIntermediateField(new[] {3, 4, 8, 2, 5}, fieldValue, gameCalculator))
        {
            numberField = 5;

            GoToField(numberField, gameCalculator, zeroes, moveCounter);
        }
        else if (CheckIntermediateField(new[] {4, 5, 6, 0, 3}, fieldValue, gameCalculator))
        {
            numberField = 3;

            GoToField(numberField, gameCalculator, zeroes, moveCounter);
        }
        else if (CheckIntermediateField(new[] {1, 4, 6, 8, 7}, fieldValue, gameCalculator))
        {
            numberField = 7;

            GoToField(numberField, gameCalculator, zeroes, moveCounter);
        }

        if (numberField != VerificationNumber)
        {
            return true;
        }

        return false;
    }
}