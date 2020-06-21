/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		LavaTile.cs
* Date Created: 6/19/2020
*
* Class: LavaTile
*
* Purpose: Defines attributes for a lava tile
*   (Concrete Decorator for Tile as part of Decorator Pattern)
* 
* Methods:
*    public override double CalculateDamage()
*       Calculates damage the tile deals and returns that value
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTile : Tile
{
    public override bool IsSink
    {
        get { return true; }
    }

    //Calculates damage the lava will deal and returns it
    public override double CalculateDamage()
    {
        //Sample code
        return 5;
    }
}
