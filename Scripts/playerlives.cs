using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/** 
 * Holds data and handles the players health. 
 * @author Riviere Seguie
 */
public class playerlives : MonoBehaviour
{
    
    public GameObject heart1, heart2, heart3, gameOver;/**< Game objects for health icons*/
    public static int health;/**< this is to track the players health*/

    void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);

    }
    // Update is called once per frame
    /** 
    * This will update the players health 
    * If the players health reaches zero it will send it to the "game over" menu
    */
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                //Time.timeScale = 0;
                // buttonM.gameover();
                SceneManager.LoadScene("gameover");
                //health += 3;
                break;
        }

    }

}
