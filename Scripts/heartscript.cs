using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
 * Adds a heart or life to the character/player 
 * @author Riviere Seguie
 */
public class heartscript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        playerlives.health += 1;
    }
}
