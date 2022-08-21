using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountLabel : MonoBehaviour
{
    public int cubeNumber;
    private TMPro.TextMeshProUGUI _cubeUI;

    public void Update()
    {
        GameObject[] cubenumbs = GameObject.FindGameObjectsWithTag("cube");
        cubeNumber = cubenumbs.Length;
        _cubeUI = GetComponent<TMPro.TextMeshProUGUI>();
        _cubeUI.text = $"Cubes: {Mathf.Ceil(cubeNumber)}";
    }
}
