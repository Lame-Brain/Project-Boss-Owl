/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts & Ethan Roberts
* Filename:		GameManager.cs
* Date Created: 8/7/2019
*
* Class: GameManager (DontDestroyOnLoad)
*
* Purpose: Stores global properties and instances for the game such as the Map and Player 
*
* Manager Functions:
*       void Awake()
* Methods:
*       
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /******* Const Globals ******/
    public const float SCALE_TILES = .32f;

    public const char FILE_DELIMITER = '|';

    //Directory Globals
    public const string DIRECTORY_RESOURCE_TILES = "Tiles";
    public const string DIRECTORY_CSV_FILES = "Assets/Resources/Files/";

    /******* Const Globals ******/

    public static GameManager m_instance;
    public MapManager m_mapManager;

    private void Awake()
    {
        if (m_instance != null && m_instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            m_instance = this;
        }
        DontDestroyOnLoad(this);

        //Allocation of components
        m_mapManager = gameObject.AddComponent<MapManager>();

        //Testing Map
        m_mapManager.BuildMap("OverworldTileID.csv");
    }


}
