using System.Collections.Generic;
using UnityEngine;

public class OpponentIsFirstMove
{
    private RandomNumbers _myRandomNumber;

    private const int FieldNumberFour = 4;

    public void GoFirstTime(GameCalculator gameCalculator, List<GameObject> zeroes, MoveCounter moveCounter)
    {
        _myRandomNumber = new RandomNumbers();

        int numberField;

        if (gameCalculator._fieldValues[FieldNumberFour] == FieldValue.Cross)
        {
            var randomAngularNumber = _myRandomNumber.RandomCornerNumber();

            gameCalculator._fieldValues[randomAngularNumber] = FieldValue.Zero;

            numberField = randomAngularNumber;
        }
        else
        {
            gameCalculator._fieldValues[FieldNumberFour] = FieldValue.Zero;

            numberField = FieldNumberFour;
        }

        zeroes[numberField].SetActive(true);

        moveCounter.IncreaseCount();
    }
}