/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		ShallowWaterTile.cs
* Date Created: 6/19/2020
*
* Class: ShallowWaterTile
*
* Purpose: Defines attributes for a shallow water tile
*   (Concrete Decorator for Tile as part of Decorator Pattern)
* 
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShallowWaterTile : Tile
{
    public override bool IsWater
    {
        get { return true; }
    }
}
