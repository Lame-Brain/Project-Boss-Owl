/**********************************************************************************************************************************************************************************************************************
* Author:		Ethan Roberts
* Filename:		Tile.cs
* Date Created: 8/13/2019
*
* Class: Deco
*
* Purpose: Stores information about objects on the Decoration layer.
*
* Methods:
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deco : MonoBehaviour
{
    //These values are used to override the values on Tile, if they are present.
    public bool m_isBlockedFlying, m_isBlockedGround, m_isWater, m_isShallow, m_isDecorable;
    public double m_damage, m_addDamage;
}