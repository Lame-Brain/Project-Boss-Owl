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
*   
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
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
}
