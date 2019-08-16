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
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int m_xCoord, m_yCoord;
    private bool m_isMoving = false;
    public Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        m_animator.SetBool("isMoving", m_isMoving);
    }
}
