﻿/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts & Ethan Roberts
* Filename:		MapMaker.cs
* Date Created: 8/8/2019
*
* Class: MapMaker (DontDestroyOnLoad)
*
* Purpose: Places tiles to create a 2D map based on the 2D array created by the GameManager
*
* Manager Functions:
*       void Awake()
*           Loads prefab folder into GameObject array and sets their IDs
* Methods:
*       void PlaceMap(Tile[,] map)
*           Calls place tile for each element of the array
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    private GameObject[] m_tiles;
    private GameObject[] m_decorations;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        //Load all Tiles and Decorations
        m_tiles = Resources.LoadAll(GameManager.DIRECTORY_RESOURCE_TILES, typeof(GameObject)).Cast<GameObject>().ToArray();
        m_decorations = Resources.LoadAll(GameManager.DIRECTORY_RESOURCE_DECORATIONS, typeof(GameObject)).Cast<GameObject>().ToArray();

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
    public void PlaceMap(Tile[,] map)
    {
        for (int y = map.GetLength(1) - 1; y >= 0; --y)
        {
            for (int x = 0; x < map.GetLength(0); ++x)
            {
                //Places a tile of the type specified by the current array index
                //The y for map is calculated to be as many steps away from 0 as y is steps away from map.Getlength(1)

                //Place tile sprite
                Instantiate(m_tiles[map[x, map.GetLength(1) - (y + 1)].TileSpriteId], new Vector2(x * GameManager.SCALE_TILES, y * GameManager.SCALE_TILES), Quaternion.identity);

                //Place decoration sprite so long as it is not equal to -1 in which case no decoration sprite exists at the index
                if(map[x, map.GetLength(1) - (y + 1)].DecoratorSpriteId != -1)
                Instantiate(m_decorations[map[x, map.GetLength(1) - (y + 1)].DecoratorSpriteId], new Vector2(x * GameManager.SCALE_TILES, y * GameManager.SCALE_TILES), Quaternion.identity);
            }
        }
    }

    
}
