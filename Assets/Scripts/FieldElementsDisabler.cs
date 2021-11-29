using System.Collections.Generic;
using UnityEngine;

public class FieldElementsDisabler : MonoBehaviour
{
    [SerializeField] private List<GameObject> _circles;

    [SerializeField] private List<GameObject> _crosses;

    private const int NumberOfFields = 9;

    private void Start()
    {
        for (var i = 0; i < NumberOfFields; i++)
        {
            _circles[i].SetActive(false);

            _crosses[i].SetActive(false);
        }
    }
}