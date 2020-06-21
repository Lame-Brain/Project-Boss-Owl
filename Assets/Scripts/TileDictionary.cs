/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		TileDictionary.cs
* Date Created: 6/19/2020
*
* Class: TileDictionary
*           Singleton
*
* Purpose: Wrapper for a dictionary of Tiles stored as Tile with an integer key
*   (Singleton Pattern)
* Manager Functions:
*       private TileDictionary()
*           Instantiates underlying dictionary
* Methods:
*       public Tile FetchTile(int key)
*           Returns a tile value based on the passed in key
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
    private Dictionary<int, AbstractTile> _tileDict;

    private TileDictionary()
    {
        _tileDict = new Dictionary<int, AbstractTile>();
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
    public AbstractTile FetchId(int key)
    {
        return _tileDict[key];
    }

    //Places all tiles into the dictionary
    public void AddAllTiles()
    {
        //Loads all files paths in the prefab directory into an array
        //Spefically searches for .prefab files
        string[] prefabFiles = Directory.GetFiles(GameManager.DIRECTORY_RESOURCES + "/" + GameManager.DIRECTORY_RESOURCE_TILE_PREFABS, 
            "*.prefab", SearchOption.AllDirectories);

        GameObject[] objs = new GameObject[prefabFiles.Length];
        //Loads each prefab into the dictionary with a key and sets the key of the associated tile
        for (int i = 0; i < prefabFiles.Length; ++i)
        {
            //Load current tile prefab
            prefabFiles[i] = prefabFiles[i].Replace("\\", "/");
            prefabFiles[i] = Path.ChangeExtension(prefabFiles[i], null);
            prefabFiles[i] = prefabFiles[i].Substring((GameManager.DIRECTORY_RESOURCES + "/").Length);

            objs[i] = Resources.Load<GameObject>(prefabFiles[i]);
            Object.Instantiate(objs[i]);
            //Add tile to the dictionary
            //_tileDict.Add(i, tile);

            //Set the key of the current tile
            //tile.TileDictKey = i;
        }
    }
}
