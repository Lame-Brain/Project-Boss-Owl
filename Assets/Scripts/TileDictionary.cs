/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		TileDictionary.cs
* Date Created: 6/19/2020
*
* Class: TileDictionary
*           Singleton
*
* Purpose: Wrapper for a dictionary of Tiles stored as Tile with a string key
*   (Singleton Pattern)
* Manager Functions:
*       public TileDictionary()
*           Adds all tiles into the dictionary with an appropriate key
* Methods:
*       public int FetchId(string key)
*           Returns an id value based on the passed in key
*       private void AddAllTiles()
*           Helper function to add all tile prefabs to the dictionary
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TileDictionary
{
    private static TileDictionary _instance;
    private Dictionary<string, AbstractTile> _tileDict;

    //Places all tiles into the dictionary
    private TileDictionary()
    {
        _tileDict = new Dictionary<string, AbstractTile>();
        //AddAllTiles();
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
        //Loads all tiles in as AbstractTiles to an array
        AbstractTile[] tiles;
        tiles = Resources.LoadAll(GameManager.DIRECTORY_RESOURCE_SPRITES, typeof(AbstractTile)).Cast<AbstractTile>().ToArray();

        //Add each tile to the dictionary
        foreach (AbstractTile tile in tiles)
        {
            _tileDict.Add("test", tile);
        }
    }
}
