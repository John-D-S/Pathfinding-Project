using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    PosX,
    NegX,
    PosY,
    NegY,
    PosZ,
    NegZ
}

public class RoomModule : MonoBehaviour
{
    public Dictionary<Direction, RoomModule> neighbourModules = new Dictionary<Direction, RoomModule>();

    private void SetNeighbours(List<List<List<RoomModule>>> grid, Vector3Int pos)
    {
        for (int i = 0; i < 6; i++)
        {
            Vector3Int neighbourPos = pos + directionOffsets[i];
            if (neighbourPos.x)
            {

            }
            neighbourModules.Add(grid[pos.x][pos.y][pos.])
        }
    }

    private Vector3Int[] directionOffsets =
    {
        new Vector3Int(1, 0, 0),
        new Vector3Int(-1, 0, 0),
        new Vector3Int(0, 1, 0),
        new Vector3Int(0, -1, 0),
        new Vector3Int(0, 0, 1),
        new Vector3Int(0, 0, -1)
    };
}
