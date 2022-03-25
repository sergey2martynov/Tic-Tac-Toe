using System.Collections.Generic;

public static class ExtensionForCrossesVictoryDetector
{
    public static bool IsFieldValuesWon(this List<FieldValue> fieldValues, FieldValue checkedValue)
    {
        if (fieldValues[0] == checkedValue &&
            fieldValues[1] == checkedValue &&
            fieldValues[2] == checkedValue ||
            fieldValues[3] == checkedValue &&
            fieldValues[4] == checkedValue &&
            fieldValues[5] == checkedValue ||
            fieldValues[6] == checkedValue &&
            fieldValues[7] == checkedValue &&
            fieldValues[8] == checkedValue ||
            fieldValues[0] == checkedValue &&
            fieldValues[3] == checkedValue &&
            fieldValues[6] == checkedValue ||
            fieldValues[1] == checkedValue &&
            fieldValues[4] == checkedValue &&
            fieldValues[7] == checkedValue ||
            fieldValues[2] == checkedValue &&
            fieldValues[5] == checkedValue &&
            fieldValues[8] == checkedValue ||
            fieldValues[6] == checkedValue &&
            fieldValues[4] == checkedValue &&
            fieldValues[2] == checkedValue ||
            fieldValues[0] == checkedValue &&
            fieldValues[4] == checkedValue &&
            fieldValues[8] == checkedValue)
        {
            return true;
        }

        return false;
    }
}