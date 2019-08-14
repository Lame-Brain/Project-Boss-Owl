/**********************************************************************************************************************************************************************************************************************
* Author:		Ethan Roberts
* Filename:		Tile.cs
* Date Created: 8/10/2019
*
* Class: Tile
*
* Purpose: Stores scripts, properties, and int tile type for each tile on the map
*
* Methods:
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile: MonoBehaviour
{
    public bool m_isBlockedFlying, m_isBlockedGround, m_isWater,  m_isSink, m_isDecorable;
    public double m_damage;
    public int m_TileID;


    public void setID(int id)
    {
        this.m_TileID = id;
    }

}

