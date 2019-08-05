using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/** 
 * Manages switching scenes using button system. 
 * @author Riviere Seguie
 */
public class buttonM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Update is called once per frame
    /** 
    * This will take the player to the starting level
    */
    public void level1()
    {
        SceneManager.LoadScene("level1");
    }
    // Update is called once per frame
    /** 
    * This will take the player to the controls menu
    */
    public void controls()
    {
        SceneManager.LoadScene("controls");
    }
    // Update is called once per frame
    /** 
    * This will take the player to the play again menu 
    */
    public void gameover()
    {
        SceneManager.LoadScene("gameover");
    }
    // Update is called once per frame
    /** 
    * This will take the player to the main menu
    */
    public void playermenu()
    {
        SceneManager.LoadScene("playermenu");
    }
    // Update is called once per frame
    /** 
    * This will close the application or game
    */
    public void Quitgame()
    {
        Application.Quit();
    }
}
