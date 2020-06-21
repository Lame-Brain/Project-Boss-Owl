/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		TileDictionary.cs
* Date Created: 6/19/2020
*
* Class: TileDictionary
*           Singleton
*
* Purpose: Wrapper for a dictionary of Tiles stored as Tile with a string path to the prefab as a key
*   (Singleton Pattern)
* Manager Functions:
*       private TileDictionary()
*           Instantiates underlying dictionary
* Methods:
*       public int FetchId(string key)
*           Returns an id value based on the passed in key
*       public void AddAllTiles()
*           Function to add all tile prefabs to the dictionary. Should be called after dictionary instantiation
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine;

public class TileDictionary
{
    private static TileDictionary _instance;
    private Dictionary<string, AbstractTile> _tileDict;

    private TileDictionary()
    {
        _tileDict = new Dictionary<string, AbstractTile>();
    }

    public static TileDictionary Instance
    {
        get 
        {
            if (_instance == null)
            {
                _instance = new TileDictionary();
            }

            return _instance;
        }
    }

    //Wrapper for getter
    public AbstractTile FetchId(string key)
    {
        return _tileDict[key];
    }

    //Helper function to place all tiles into the dictionary
    public void AddAllTiles()
    {
        //Loads all files paths in the prefab directory into an array as the key
        string[] keys = Directory.GetFiles(GameManager.DIRECTORY_RESOURCES + "\\" + GameManager.DIRECTORY_RESOURCE_TILE_PREFABS, 
            "*.prefab", SearchOption.AllDirectories);
        
        //Uses the keys path to find the tile and uses both itself and that tile to add an entry to the dictionary
        foreach(string key in keys)
        {
            _tileDict.Add(key, Resources.Load<AbstractTile>(key));
        }
    }
}
