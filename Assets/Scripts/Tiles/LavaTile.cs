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
*   protected override void Awake()
*       Instantiates all relevant states inherited from Tile
*    public override double CalculateDamage()
*       Calculates damage the tile deals and returns that value
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTile : Tile
{
    protected override void Awake()
    {
        base.Awake();
        _isSink = true;
        _tileSpriteId = -1;
    }
    
    //Calculates damage the lava will deal and returns it
    public override double CalculateDamage()
    {
        //Sample code
        return 5;
    }
}
