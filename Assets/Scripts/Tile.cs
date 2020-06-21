/**********************************************************************************************************************************************************************************************************************
* Author:		Ethan Roberts & Brett Roberts
* Filename:		Tile.cs
* Date Created: 8/10/2019
*
* Class: Tile
*
* Purpose: Gives default (non-abstract) definitions for Tile methods and states
*   (Concrete Component for Tile as part of Decorator Pattern)
*
* Manager Functions:
*       void Awake()
* 
* Methods:
* public override double CalculateDamage()
*    Calculates damage the tile deals and returns that value
/**********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile: AbstractTile
{
    public override bool IsBlockedFlying
    {
        get { return false; }
    }

    public override bool IsBlockedGround
    {
        get { return false; }
    }

    public override bool IsWater
    {
        get { return false; }
    }

    public override bool IsSink
    {
        get { return false; }
    }

    public override int TileDictKey
    {
        get { return _tileDictKey; }
        set { _tileDictKey = value; }
    }

    //Base damage of a tile is 0
    public override double CalculateDamage()
    {
        return 0;
    }
}

