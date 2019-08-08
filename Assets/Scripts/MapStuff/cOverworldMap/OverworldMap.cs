/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		OverworldMap.cs
* Date Created: 8/7/2019
*
* Class: OverworldMap
*
* Purpose: Main map that the player will traverse as they move between locations (dungeons, caves, etc...)
*
* Manager functions:
*	OverworldMap()
*		Initializes the 2D list
* Methods:
*       
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldMap : MonoBehaviour
{
    private List<List<Location>> m_list;

    //Default ctor to allocate memory for m_list
    public OverworldMap()
    {
        //Create a list of lists (2D list "array") that will be as large as the X-axis
        m_list = new List<List<Location>>(GameManager.m_instance.SIZE_OVERWORLD_X);

        //For each list within m_list create a list that will be as large as the Y-axis
        for (int i = 0; i < GameManager.m_instance.SIZE_OVERWORLD_X; ++i)
            m_list[i] = new List<Location>(GameManager.m_instance.SIZE_OVERWORLD_Y);
    }


}
