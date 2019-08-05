using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class boss : MonoBehaviour
{

    public int health;
    public int damage;
    private float timeBtwDamage = 1.5f;
   
    public Slider healthBar;
    public bool isDead;

    private void Start()
    {
      
    }

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

