using System.Collections.Generic;
using UnityEngine;

public class RandomNumbers
{
    private const int NumberOfLowerLeftField = 0;
    private const int NumberOfLowerRightField = 2;
    private const int NumberOfUpperLeftField = 6;
    private const int NumberOfUpperRightField = 8;

    private readonly List<int> _numbersOfCornerFields = new List<int>()
        {NumberOfLowerLeftField, NumberOfLowerRightField, NumberOfUpperLeftField, NumberOfUpperRightField};

    public int RandomCornerNumber()
    {
        var cornerFieldNumber = _numbersOfCornerFields[Random.Range(0, _numbersOfCornerFields.Count)];

        return cornerFieldNumber;
    }
}