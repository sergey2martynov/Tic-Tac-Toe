using System.Collections.Generic;
using UnityEngine;

public class CrossesOf : MonoBehaviour
{
    [SerializeField] private List<GameObject> _crosses;
    private void Start()
    {
        for (var i = 0; i<9;i++)
        {
            _crosses[i].SetActive(false);
        }
    }
}
