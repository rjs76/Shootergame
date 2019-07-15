using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float Stoppingdistance;
    public float retreatDistance;

    public float timebtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;

    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        timebtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, Player.position)> Stoppingdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, Player.position) < Stoppingdistance && Vector2.Distance(transform.position, Player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, Player.position)< retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, -speed * Time.deltaTime);
        }


        if(timebtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timebtwShots = startTimeBtwShots;
        }
        else
        {
            timebtwShots -= Time.deltaTime;
        }

    }
    /**
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("blast"))
        {
            Destroy(gameObject, 5);
        }
            
    }
    */
}
