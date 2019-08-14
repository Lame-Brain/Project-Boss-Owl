/**********************************************************************************************************************************************************************************************************************
* Author:		Ethan Roberts
* Filename:		Decoration.cs
* Date Created: 8/13/2019
*
* Class: Decoration
*
* Purpose: Stores information about objects on the Decoration layer.
*
* Methods:
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoration : MonoBehaviour
{
    //These values are used to override the values on Tile, if they are present.
    public bool m_addBlockFlyers, m_addUnblockFlyers, m_addBlockGround, m_addUnblockGround, m_addIsWater, m_addIsSolid, m_addIsShallow, addIsNotShallow, m_cancelTileDamage;
    public double m_addDamage;
    public int m_spriteID;
}