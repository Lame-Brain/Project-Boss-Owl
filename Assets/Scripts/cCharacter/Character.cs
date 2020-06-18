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

    protected Vector2 m_pos, m_nextPos;
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
        //if(m_pos != m_nextPos)
        //    m_animator.SetBool("isMoving", m_isMoving);
        //transform.position = m_pos;
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
        MoveChar(mvDir);
    }

    virtual protected void MoveChar(Move_Direction mvDir)
    {

    }
}
