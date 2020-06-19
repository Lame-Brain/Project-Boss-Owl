/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		AbstractTile.cs
* Date Created: 6/18/2020
*
* Class: AbstractTile
*
* Purpose: Gives abstract states and methods for Tiles. 
*   (Abstract Component for Tile as part of Decorator Pattern)
* 
* Methods:
*  public double CalculateDamage()
*   Calculates damage the tile deals and returns that value
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class AbstractTile : MonoBehaviour
{
    protected bool _isBlockedFlying, _isBlockedGround, _isWater, _isSink;
    protected int _decoratorSpriteId;
    protected int _tileSpriteId;

    //Defines abstract properties for each state to be decorable
    public abstract bool IsBlockedFlying
    { get; }
    public abstract bool IsBlockedGround
    { get; }
    public abstract bool IsWater
    { get; }
    public abstract bool IsSink
    { get; }
    public abstract int DecoratorSpriteId
    { get; set; }

    public abstract int TileSpriteId
    { get; set; }

    public abstract double CalculateDamage();
}
