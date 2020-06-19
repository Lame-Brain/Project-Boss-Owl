/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		SpikePitDecorator.cs
* Date Created: 6/19/2020
*
* Class: SpikePitDecorator
*
* Purpose: Defines a door decorator to place on tiles
*   (Concrete Decorator for Tile as part of Decorator Pattern)
* 
* Properties:
*   public override bool IsBlockedGround
*       Returns whether the door is blocking (closed is blocking, open is not)
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

public class SpikePitDecorator : TileDecorator
{
    private void Awake()
    {
            
    }

    public override int Damage
    {
        get { return base.Damage + CalcDamage(); }
    }

    //Calculate the spike pit will deal
    protected int CalcDamage()
    {
        return 5;
    }
}
