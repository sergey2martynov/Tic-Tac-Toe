using UnityEngine;

public class RandomNumbers
{
    public int RandomAngularNumber()
    {
        var angularNumber = Random.Range(0, 4);

        switch (angularNumber)
        {
            case 1:
                angularNumber += 1;
                break;
            case 2:
                angularNumber *= 3;
                break;
            case 3:
                angularNumber = angularNumber * 3 - 1;
                break;
        }

        return angularNumber;
    }
}