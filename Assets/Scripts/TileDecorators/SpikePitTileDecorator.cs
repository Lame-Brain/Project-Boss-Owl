/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		SpikePitTileDecorator.cs
* Date Created: 6/19/2020
*
* Class: SpikePitTileDecorator
*
* Purpose: Defines a spike pit decorator to place on tiles
*   (Concrete Decorator for Tile as part of Decorator Pattern)
* 
* Methods:
*  public override double CalculateDamage()
*   Calculates damage the tile deals and returns that value
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePitDecorator : TileDecorator
{
    //Calculate the spike pit will deal and returns it
    public override double CalculateDamage()
    {
        //Sample code, adds the damage done by the tile to spike decoration
        return _inner.CalculateDamage() + 3;
    }
}
