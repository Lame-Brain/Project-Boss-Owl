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
*   Awake()
*       Instantiates all relevant states inherited from Tile
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
        CalculateDamage();
    }
    
    //Calculates damage the lava will deal and assigns it to the damage state
    protected void CalculateDamage()
    {
        //Example code
        _damage = 5;
    }
}
