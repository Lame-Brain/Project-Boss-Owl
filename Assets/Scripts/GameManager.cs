/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
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

    //Map Globals
    public int SIZE_OVERWORLD_X = 5;
    public int SIZE_OVERWORLD_Y = 5;

    private void Awake()
    {
        m_instance = this;
    }

    public OverworldMap m_overworldMap;
}
