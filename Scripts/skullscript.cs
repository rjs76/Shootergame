﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
 * Subtracts health from the player 
 * @author Riviere Seguie
 */
public class skullscript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            playerlives.health -= 1;
        }
    }
}
