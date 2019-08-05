using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
 * holds data and manages how the bullet reacts in terms of damage, speed, and to other objects
 * @author Riviere Seguie
 */
public class bullet : MonoBehaviour
{
    public int damage;/**< is for the the bullet damage*/
    public float speed;/**< is for the the bullet speed*/
    public float velx = 5f;/**< is for the the bullet velocity in the x direction*/
    float vely = 6f; /**< is for the the bullet velocity in the y direction*/
    Rigidbody2D rgb; /**< is for the rigidbody of the bullet*/

    public GameObject platform1;/**< is for the platform to collide with*/

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rgb.velocity = new Vector2 (velx, vely);
        Destroy(gameObject, 3f);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "platform1")
            Destroy(gameObject);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // deal the boss some damage + spawn particle effects
      if (other.CompareTag("Boss"))
        {
            other.GetComponent<boss>().health -= damage;
            Destroy(gameObject);
        }  
    }
}
