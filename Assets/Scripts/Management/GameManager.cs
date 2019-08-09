/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts & Ethan Roberts
* Filename:		GameManager.cs
* Date Created: 8/7/2019
*
* Class: GameManager
*
* Purpose: Stores global properties and instances for the game such as the Map and Player 
*
* Methods:
*       void Awake()
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager m_instance;
    //Map Globals
    public float SCALE_TILES = 0.32f;

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

        //TESTING MAP
        int[,] map_test = new int[5, 5]
        {{1,1,1,0,1},
         {1,0,2,2,1},
         {1,2,2,0,1},
         {1,2,2,2,1},
         {0,1,1,0,1}};

        MapMaker mMaker = gameObject.AddComponent<MapMaker>();
        mMaker.MakeMap(map_test);
                
    }

    
}
