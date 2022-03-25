using System;
using System.Collections.Generic;
using UnityEngine;

public class VictoryDetector
{
    public GameState CheckVictoryPlayers(List<FieldValue> fieldValues, TextOutput textOutput, FieldValue fieldValue,
        GameState gameState)
    {
        try
        {
            if (fieldValues.Count != 9)
            {
                throw new Exception("Wrong number in the list ");
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }

        if (fieldValues.IsFieldValuesWon(fieldValue))
        {
            textOutput.ShowTextOfWinner(gameState);

            return gameState;
        }

        return GameState.Game;
    }
}