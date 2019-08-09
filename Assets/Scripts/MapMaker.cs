using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    public GameObject tilePlainGrass, tilePlainHedge, tilePlainTree;

    public MapMaker(int[,] map)
    {
        for(int y=0; y < map.GetLength(1); y++)        {
            for(int x = 0; x < map.GetLength(0); x++)            {
                instantiate
            }
        }
    }

}
