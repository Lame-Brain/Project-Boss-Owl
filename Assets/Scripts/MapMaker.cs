using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    public GameObject tilePlainGrass, tilePlainHedge, tilePlainTree;

    public void MakeMap(int[,] map)
    {
        for (int y = 0; y < map.GetLength(1); ++y)
        {
            for (int x = 0; x < map.GetLength(0); ++x)
            {
                Debug.Log(map[x, y].ToString());
                Instantiate(tilePlainGrass, new Vector2(x * 32, y * 32), Quaternion.identity);
            }
        }
    }
}
