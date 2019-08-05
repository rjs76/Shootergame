using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartscript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        playerlives.health += 1;
    }
}
