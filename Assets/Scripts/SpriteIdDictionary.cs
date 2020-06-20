/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		SpriteIdDictionary.cs
* Date Created: 6/19/2020
*
* Class: SpriteIdDictionary
*           Singleton
*
* Purpose: Wrapper for a dictionary of SpriteIds stored as an integer with a string key
*   (Singleton Pattern)
* Manager Functions:
*       public SpriteIdDictionary()
*           Adds all sprites into the dictionary with an appropriate key
* Methods:
*       public int FetchId(string key)
*           Returns an id value based on the passed in key
*       private void AddAllSprites()
*           Helper function to add spriteIds. Called by the ctor
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteIdDictionary
{
    private static SpriteIdDictionary _instance;
    private Dictionary<string, int> _spriteDict;

    //Places all spriteIds into the dictionary
    private SpriteIdDictionary()
    {
        _spriteDict = new Dictionary<string, int>();

        //example
        //_spriteDict.Add("key", 1);
    }

    public static SpriteIdDictionary Instance
    {
        get 
        {
            if (_instance == null)
            {
                _instance = new SpriteIdDictionary();
            }

            return _instance;
        }
    }

    //Wrapper for getter
    public int FetchId(string key)
    {
        return _spriteDict[key];
    }

}
