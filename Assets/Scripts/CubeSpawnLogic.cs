using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnLogic : MonoBehaviour
{
    // Odwołanie do scriptableobject
    [SerializeField] private NumberOfCubes _infoCubeNumber;

    // Wartość promienia okręgu
    private float _radius = 5f;

    void Start()
    {
        CreateCubes();
    }

    void CreateCubes()
    {
        // Przypisane wartości dla kolejnego kąta, gdzie 2pi = 360 stopni
        float nextAngle = 2 * Mathf.PI / _infoCubeNumber.CubesNum;
        float angle = 0;

        // Pętla do momentu osiągnięcia wszystkich prefabów
        for(int i = 0; i < _infoCubeNumber.CubesNum; i++)
        {
            float x = Mathf.Cos(angle) * _radius;
            float y = Mathf.Sin(angle) * _radius;
            
            // Inicjowanie prefab i przypisanie nowego kąta dla kolejnego obiektu
            Instantiate(_infoCubeNumber.CubePrefab, new Vector2(x,y), Quaternion.identity);
            angle += nextAngle;
        }
    }

    void Update()
    {
        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
