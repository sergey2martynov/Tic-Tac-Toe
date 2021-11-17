using System.Collections.Generic;
using UnityEngine;

public class CirclesOf : MonoBehaviour
{
    [SerializeField] private List<GameObject> _circles;
    private void Start()
    {
        for (var i = 0; i<9;i++)
        {
            _circles[i].SetActive(false);
        }
    }
}
