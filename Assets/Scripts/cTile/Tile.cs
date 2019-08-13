﻿/**********************************************************************************************************************************************************************************************************************
* Author:		Ethan Roberts
* Filename:		Tile.cs
* Date Created: 8/10/2019
*
* Class: Tile
*
* Purpose: Stores information about Tiles that the map is built out of.
*
* Methods:
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile: MonoBehaviour
{
    public bool m_isBlockedFlying, m_isBlockedGround, m_isWater,  m_isShallow, m_isDecorable;
    public double m_damage;

}

