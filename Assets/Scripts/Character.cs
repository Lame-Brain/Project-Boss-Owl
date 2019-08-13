/**********************************************************************************************************************************************************************************************************************
* Author:		Ethan Roberts
* Filename:		Tile.cs
* Date Created: 8/13/2019
*
* Class: Deco
*
* Purpose: Stores information about Character objects.
*
* Methods:
***********************************************************************************************************************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int m_xCoord, m_yCoord;
    private bool m_isMoving;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("isMoving", m_isMoving);
    }
}
