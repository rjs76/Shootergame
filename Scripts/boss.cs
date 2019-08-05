using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/** 
 * Holds data and handles the boss health and mechanics. 
 * @author Riviere Seguie
 */
public class boss : MonoBehaviour
{

    public int health;/**< is for the the boss enemy health*/
    public int damage;/**< is for the the damage that the boss enemy can take*/
    private float timeBtwDamage = 1.5f;/**< time of which in between the shots*/

    public Slider healthBar;/**< the health bar which will decrease depending on the damage given to the boss*/
    public bool isDead; /**< Determines if the boss enemy health is depleted to then determine it died*/

    private void Update()
    {


        // give the player some time to recover before taking more damage !
        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }

        healthBar.value = health;

        if (health == 0)
        {
            isDead = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // deal the player damage ! 
        if (other.CompareTag("Player") && isDead == false)
        {
            if (timeBtwDamage <= 0)
            {
               // camAnim.SetTrigger("shake");
                other.GetComponent<movement>().health -= damage;
            }
        }
    }
}

