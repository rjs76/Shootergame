using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
 * Manages the Camera movement so it can follow the player
 * @author Riviere Seguie
 */
public class cameramove : MonoBehaviour
{
    private GameObject player;/**< this is to identify the player*/
    public float xMin = -2;/**< This is the minimum x for the camera to reach*/
    public float xMax = 40;/**< This is the minimum x for the camera to reach*/
    public float yMin = 0;/**< This is the minimum y for the camera to reach*/
    public float yMax = 6;/**< This is the maximum y for the camera to reach*/
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    /** 
    * this will change the view of the camera so it is alligned with the player
    */
    void LateUpdate()
    {
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);

    }
}
