/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		Player.cs
* Date Created: 8/15/2019
*
* Class: Player (Child of Character)
*
* Purpose: Stores attributes and actions specific to the player character
*
* Manager Functions:
*   Start()
*   Update()
* 
* Methods:
*   
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    override protected void Start()
    {
        base.Start();
    }

    override protected void Update()
    {
        GameManager.m_instance.m_player.transform.position = m_pos;
    }

    override protected void MoveChar(Move_Direction mvDir)
    {
        switch (mvDir)
        {
            case Move_Direction.UP:
                m_pos = new Vector2(m_pos.x, m_pos.y + 1);
                break;
            case Move_Direction.DOWN:
                m_pos = new Vector2(m_pos.x, m_pos.y - 1);
                break;
            case Move_Direction.LEFT:
                m_pos = new Vector2(m_pos.x - 1, m_pos.y);
                break;
            case Move_Direction.RIGHT:
                m_pos = new Vector2(m_pos.x + 1, m_pos.y);
                break;
            default:
                throw new System.Exception("Move direction was outside of the bounds of enumeration \"Move_Direction\"");

        }
    }
}
