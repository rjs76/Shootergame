using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
 * this is for the enemy to patrol
 * @author Riviere Seguie
 */
public class patrol : MonoBehaviour
{
    public float speed;/**< This is the for the speed*/
    public float distance;/**< This is the for the distance*/
    private bool movingRight = true;/**< This is to determine when it goes to the Right*/

    public Transform groundDetection;/**< This is transform it based off ground dectection*/


    // Update is called once per frame
    /** 
    * This will update the enemey to check the raycast
    * Once it hits the enemy will face the other direction 
    */
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        //detection point to turn the other way
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
