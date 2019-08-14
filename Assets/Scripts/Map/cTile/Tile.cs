/**********************************************************************************************************************************************************************************************************************
* Author:		Ethan Roberts & Brett Roberts
* Filename:		Tile.cs
* Date Created: 8/10/2019
*
* Class: Tile
*
* Purpose: Stores scripts, properties, and int tile type for each tile on the map
*
* Manager Functions:
*       void Awake()
* 
* Methods:
*           
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile: MonoBehaviour
{
    public bool m_isBlockedFlying, m_isBlockedGround, m_isWater,  m_isSink, m_isDecorable;
    public double m_damage;
    public int m_spriteID;
    public List<Decoration> m_decorations;

    private void Awake()
    {
        m_decorations = new List<Decoration>();
    }

}

