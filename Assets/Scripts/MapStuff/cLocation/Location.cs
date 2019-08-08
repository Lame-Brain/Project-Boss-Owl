/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		Location.cs
* Date Created: 8/7/2019
*
* Class: Location
*
* Purpose: Holds the properties of an individual tile on the OverworldMap
*
* Methods:
*       
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public enum TileLayer
    {
        GROUND,
        SINKING,
        WATER,
        GROUND_BLOCKING,
        BLOCKING
    }

    public enum TileType
    {
        //
    }

    public Sprite m_sprite;
    public TileLayer m_layer { get; }
    public TileType m_type { get; }
}
