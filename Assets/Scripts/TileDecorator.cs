/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		TileDecorator.cs
* Date Created: 6/18/2020
*
* Class: TileDecorator
*
* Purpose: Provides interface decorators and for pass through behaviour to Tile
*  (Abstract Decorator for Tile as part of the Decorator Pattern)
*
* Methods:
*   protected void Construct(AbstractTile tile)
*       Initializes this instance of the Tile Decorator to a Abstract tile to provide pass through behaviour
*   public override double CalculateDamage()
*       Calculates damage the tile deals and returns that value
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDecorator : AbstractTile
{
    protected AbstractTile _inner;

    protected void Construct(AbstractTile tile)
    {
        _inner = tile;
    }

    public override bool IsBlockedFlying
    {
        get { return _inner.IsBlockedFlying; }
    }

    public override bool IsBlockedGround
    {
        get { return _inner.IsBlockedGround; }
    }

    public override bool IsWater
    {
        get { return _inner.IsWater; }
    }

    public override bool IsSink
    {
        get { return _inner.IsSink; }
    }

    public override int DecoratorSpriteId
    {
        get { return _inner.DecoratorSpriteId; }
        set { _inner.DecoratorSpriteId = value; }
    }

    public override int TileSpriteId
    {
        get { return _inner.TileSpriteId; }
        set { _inner.TileSpriteId = value; }
    }

    public override double CalculateDamage()
    {
        return _inner.CalculateDamage();
    }
}
