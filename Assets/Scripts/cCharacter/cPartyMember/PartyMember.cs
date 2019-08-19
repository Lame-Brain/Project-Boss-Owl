/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		PartyMember.cs
* Date Created: 8/15/2019
*
* Class: PartyMember (Child of Character)
*
* Purpose: Stores attributes and actions specific to members in the players party
*
* Manager Functions:
*   Start()
*   Update()
* 
* Methods:
*   FollowPlayer()
*       Has NPC's follow the path of the player behind them within dungeons (off overworld)
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMember : Character
{
    override protected void Start()
    {
        base.Start();
    }

    override protected void Update()
    {
        base.Update();

        if (GameManager.m_gameState == GameManager.GAME_STATE.UNDERWORLD)
        {
            FollowPlayer();
        }
    }

    protected void FollowPlayer()
    {

    }
}
