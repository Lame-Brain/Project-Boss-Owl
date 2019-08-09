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
*       
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager m_instance;
    public OverworldMap m_overworldMap;

    //Map Globals
    public int SIZE_OVERWORLD_X = 5;
    public int SIZE_OVERWORLD_Y = 5;

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
        m_overworldMap = new OverworldMap();
        int[,] map_test = new int[5, 5]
        {{1,1,1,1,1},
         {1,2,2,2,1},
         {1,2,2,2,1},
         {1,2,2,2,1},
         {1,1,1,1,1}};
        for(int y = 0; y<5; y++)        {
            for(int x=0; x <5; x++)            {
                new Location(map_test[x, y]);
                Debug.Log(m_overworldMap.getTile(x,y).m_id);
            }
        }        
    }

    
}
