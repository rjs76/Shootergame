using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int damage;
    public float speed;
    public float velx = 5f;
    float vely = 6f;
    Rigidbody2D rgb;

    public GameObject platform1;

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
