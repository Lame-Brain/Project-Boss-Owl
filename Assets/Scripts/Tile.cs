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
    virtual protected void Awake()
    {
        _isBlockedFlying = false;
        _isBlockedGround = false;
        _isWater = false;
        _isSink = false;
        _decoratorSpriteId = 0;
        _tileSpriteId = 0;
    }

    public override bool IsBlockedFlying
    {
        get { return _isBlockedFlying; }
    }

    public override bool IsBlockedGround
    {
        get { return _isBlockedGround; }
    }

    public override bool IsWater
    {
        get { return _isWater; }
    }

    public override bool IsSink
    {
        get { return _isSink; }
    }

    public override int DecoratorSpriteId
    {
        get { return _decoratorSpriteId; }
        set { _decoratorSpriteId = value; }
    }

    public override int TileSpriteId
    {
        get { return _tileSpriteId; }
        set { _tileSpriteId = value; }
    }

    //Base damage of a tile is 0
    public override double CalculateDamage()
    {
        return 0;
    }
}

