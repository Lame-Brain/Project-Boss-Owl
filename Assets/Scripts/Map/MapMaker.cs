/**********************************************************************************************************************************************************************************************************************
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
*           Loads prefab folder into GameObject array
* Methods:
*       void PlaceMap(int[,] map)
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

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        //Load all Tiles into m_tiles as GameObjects
        m_tiles = Resources.LoadAll(GameManager.m_instance.DIRECTORY_RESOURCE_TILES, typeof(GameObject)).Cast<GameObject>().ToArray();
        for(int n = 0; n < m_tiles.Length; n++)
        {
            m_tiles[n].GetComponent<Tile>().setID(n);
        }
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
    public void PlaceMap(int[,] map)
    {
        for (int y = map.GetLength(1) - 1; y >= 0; --y)
        {
            for (int x = 0; x < map.GetLength(0); ++x)
            {
                //Places a tile of the type specified by the current array index
                //The y for map is calculated to be as many steps away from 0 as y is steps away from map.Getlength(1)
                Instantiate(m_tiles[map[x, map.GetLength(1) - (y + 1)]], new Vector2(x * GameManager.SCALE_TILES, y * GameManager.SCALE_TILES), Quaternion.identity);
            }
        }
    }

    
}
