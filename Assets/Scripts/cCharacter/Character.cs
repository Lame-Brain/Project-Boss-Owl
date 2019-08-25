/**********************************************************************************************************************************************************************************************************************
* Author:		Ethan Roberts & Brett Roberts
* Filename:		Character.cs
* Date Created: 8/13/2019
*
* Class: Character
*
* Purpose: Stores information about Character objects.
*
* Manager Functions:
*   Start()
*   Update()
* 
* Methods:
*   virtual protected void Move(Move_Direction mvDir)
*       Checks for collision and moves character if direction is valid
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum Move_Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    private Vector2 m_pos, m_nextPos;
    private bool m_isMoving = false;
    public Animator m_animator;

    //Character Stats
    int m_currHealth, m_maxHealth;
    int m_currStr, m_maxStr;
    int m_currDex, m_maxDex;
    int m_currCon, m_maxCon;
    int m_currIQ, m_maxIQ;
    int m_currWis, m_maxWis;


    // Start is called before the first frame update
    virtual protected void Start()
    {
        m_animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    virtual protected void Update()
    {
        if(m_pos != m_nextPos)
            m_animator.SetBool("isMoving", m_isMoving);
    }

    /**********************************************************************************************************************************************************************************************************************
    * Purpose: 
    *   Determines collision at the destination of the character and moves the player if there is none
    * 
    * Precondition: 
    *   The character is told to move through their controller
    * 
    * Postcondition:
    *   The player is moved if there is no collision at the destination and stays still if there is collision
    ***********************************************************************************************************************************************************************************************************************/
    virtual public void Move(Move_Direction mvDir)
    {
        Vector2 destination = m_pos;

        switch(mvDir)
        {
            case Move_Direction.UP:
                destination = new Vector2(m_pos.x, m_pos.y + 1);
                break;
            case Move_Direction.DOWN:
                destination = new Vector2(m_pos.x, m_pos.y - 1);
                break;
            case Move_Direction.LEFT:
                destination = new Vector2(m_pos.x + 1, m_pos.y);
                break;
            case Move_Direction.RIGHT:
                destination = new Vector2(m_pos.x + 1, m_pos.y);
                break;
            default:
                throw new System.Exception("Move direction was outside of the bounds of enumeration \"Move_Direction\"");

        }
        m_pos = destination;
    }
}
