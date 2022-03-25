using UnityEngine;

public class MoveCounter : MonoBehaviour
{
    [SerializeField] private DrawDetector _drawDetector;
    public int Count { get; private set; }

    public void IncreaseCount()
    {
        Count++;

        _drawDetector.СheckForADraw();
    }
}