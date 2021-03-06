﻿/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		DoorTileDecorator.cs
* Date Created: 6/18/2020
*
* Class: DoorTileDecorator
*
* Purpose: Defines a door decorator to place on tiles
*   (Concrete Decorator for Tile as part of Decorator Pattern)
* 
* Properties:
*   public override bool IsBlockedGround
*       Returns whether the door is blocking (closed is blocking, open is not)
*   public DecoratorSpriteId
*       Returns the spriteId for a closed door if the door is closed, or an open one if the door is opened
* Methods:
*  public void Open()
*   Sets the door to not be closed and changes sprite to an open door
*   
*  public void Close()
*   Sets the door to be closed and changes the sprite to a closed door
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTileDecorator : TileDecorator
{
    protected bool _isClosed;

    private void Awake()
    {
        _isClosed = false;
    }

    public override bool IsBlockedGround
    {
        get { return _isClosed; }
    }

    //******To be fully implemented
    public override int DecoratorSpriteId
    {
        get
        {
            //Return the closed door sprite id
            if (_isClosed)
            {
                return -1;
            }
            //Return the open door sprite id
            else
            {
                return -1;
            }
        }
    }

    public void Open()
    {
        _isClosed = false;
    }

    public void Close()
    {
        _isClosed = true;
    }
}
