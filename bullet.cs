using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float velx = 5f;
    float vely = 6f;
    Rigidbody2D rgb;

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
}
