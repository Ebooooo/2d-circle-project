using UnityEngine;

[CreateAssetMenu(fileName = "NumberOfCubes", menuName = "SO/NewNumberofCubes")]
public class NumberOfCubes : ScriptableObject
{
    [SerializeField]
    public GameObject CubePrefab;
    public int CubesNum;
}