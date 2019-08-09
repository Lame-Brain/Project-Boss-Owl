/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts & Ethan Roberts
* Filename:		MapMaker.cs
* Date Created: 8/8/2019
*
* Class: MapMaker
*
* Purpose: Places tiles to create a 2D map based on the 2D array created by the GameManager
*
* Methods:
*       void MakeMap(int[,] map)
*           Calls place tile for each element of the array
*       void PlaceTile(MapTileType mapTT)
*           Places a tile of the passed in type at the next array location
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    public GameObject tilePlainGrass, tilePlainHedge, tilePlainTree;

    public enum MapTileType
    {
        PLAIN_GRASS,
        PLAIN_HEDGE,
        PLAIN_TREE
    }

/**********************************************************************************************************************************************************************************************************************
* Purpose: 
*   Creates an onscreen map based on the passed in 2D array 
* 
* Precondition: 
*   The GameManager has read a CSV file and is calling for the map to be constructed
* 
* Postcondition:
*   The array is outputted as a map to the screen
***********************************************************************************************************************************************************************************************************************/
    public void MakeMap(int[,] map)
    {
        for (int y = 0; y < map.GetLength(1); ++y)
        {
            for (int x = 0; x < map.GetLength(0); ++x)
            {
                //Places a tile of the type specified by the current array index
                PlaceTile((MapTileType)map[x,y], x, y);
            }
        }
    }

/**********************************************************************************************************************************************************************************************************************
* Purpose: 
*   Places a single tile based on the type of the tile (mapTT) and the current placement location (currX and currY)
* 
* Precondition: 
*   The MakeMap function is reading through an array to build a map
* 
* Postcondition:
*   The specified tile type is placed at the specified coordinates on the screen
***********************************************************************************************************************************************************************************************************************/
    public void PlaceTile(MapTileType mapTT, int currX, int currY)
    {
        GameObject tileObj = null;

        //Sets newObj to the correct object based on the MapTileType
        switch(mapTT)
        {
            case MapTileType.PLAIN_GRASS:
                tileObj = tilePlainGrass;
                break;
            case MapTileType.PLAIN_HEDGE:
                tileObj = tilePlainHedge;
                break;
            case MapTileType.PLAIN_TREE:
                tileObj = tilePlainTree;
                break;
            default:
                Debug.Log("Map Tile type " + mapTT.ToString() + " is not a valid type");
                break;
        }

        //Place the tile
        Instantiate(tileObj, new Vector2(currX * GameManager.m_instance.SCALE_TILES, currY * GameManager.m_instance.SCALE_TILES), Quaternion.identity);
    }
}
