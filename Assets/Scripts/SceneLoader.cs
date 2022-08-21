using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private GameObject _myCanvas;
    

    void Start()
    {
        Instantiate(_myCanvas);
    }
}
