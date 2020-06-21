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
*       void Update()
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
    public const string DIRECTORY_RESOURCE_SPRITES = "Sprites";
    public const string DIRECTORY_RESOURCE_TILES = "Sprites/Tiles";
    public const string DIRECTORY_RESOURCE_DECORATIONS = "Sprites/Decos";
    public const string DIRECTORY_CSV_FILES = "Assets/Resources/Files/";
    /******* Const Globals ******/

    public static GameManager m_instance;
    private MapManager m_mapManager;
    public GameObject m_player;
    TileDictionary spriteIdDictionary = TileDictionary.Instance;

    public enum GAME_STATE
    {
        OVERWORLD,
        UNDERWORLD,
        COMBAT
    }

    public static GAME_STATE m_gameState;

    private void Awake()
    {
        if (m_instance != null && m_instance != this)
            Destroy(this.gameObject);
        else
            m_instance = this;

        DontDestroyOnLoad(this);

        //Allocation of components
        m_mapManager = gameObject.AddComponent<MapManager>();
        //m_player = gameObject.AddComponent<Player>();

        //Testing Map
        //m_mapManager.BuildMap("OverworldTileID.csv", "OverworldDecoID.csv");
        m_mapManager.BuildMap("DunjonTiles.csv", "DunjonDeco.csv");

        spriteIdDictionary.AddAllTiles();
    }

    private void Update()
    {
        /******* Temp Code to Move Player ******/
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_player.GetComponent<Player>().Move(Character.Move_Direction.UP);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_player.GetComponent<Player>().Move(Character.Move_Direction.DOWN);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_player.GetComponent<Player>().Move(Character.Move_Direction.LEFT);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_player.GetComponent<Player>().Move(Character.Move_Direction.RIGHT);
        }
        /******* End Temp Code to Move Player ******/
    }
}
