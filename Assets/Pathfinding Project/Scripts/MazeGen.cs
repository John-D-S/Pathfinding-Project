using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum direction
{
    ZPos,
    XPos,
    ZNeg,
    XNeg
}

public class MazeGen : MonoBehaviour
{
    private GameObject floorPrefab;
    private GameObject columnPrefab;
    private GameObject wallPrefab;

    private Vector3Int mazeSize;

    private List<List<List<List<GameObjectRotationPair>>>> MazeGridObjects;

    private void Start()
    {
        floorPrefab = Resources.Load<GameObject>("Floor");
        columnPrefab = Resources.Load<GameObject>("Column");
        wallPrefab = Resources.Load<GameObject>("Wall");

        mazeSize = new Vector3Int(Random.Range(5, 20), Random.Range(1, 6), Random.Range(1, 2)); 

    }

    private void CreateWallOfLines()
}
