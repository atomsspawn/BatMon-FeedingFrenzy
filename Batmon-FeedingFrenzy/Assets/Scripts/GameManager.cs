using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject GameOverScreen;     //set gameOverCanas to GameOverScreen
                                          //public TMP_Text life_text;
    public int currentlife;
    private string gameState;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        gameState = "Start";

    }


    public void UpdateLife(int health)
    {

        currentlife = health;
    }

    void Update()
    {


        if (gameState == "Start")
        {
            //print("State: Start");
            // Start the game
            if (Input.GetKeyDown("space"))
            {
                gameState = "Playing";
            }
        }
        if (gameState == "Playing")
        {
            //print("State: Playing");
            Time.timeScale = 1;
            //Check for death
            if (currentlife <= 0)
            {
                gameState = "Game Over";
            }
            //Check for OP
            if (currentlife >= 100)
            {
                currentlife = 100;
            }

            // Update your life
            //life_text.text = "Life: " + life;
        }
        if (gameState == "Game Over")
        {
            //print("State: Game Over");
            Time.timeScale = 0;
            if (!GameOverScreen.activeInHierarchy)
            {
                Debug.Log("Game over dawg");
                GameOverScreen.SetActive(true);
            }
            if (Input.GetKeyDown("space"))
            {
                GameOverScreen.SetActive(false);
                gameState = "Playing";
            }
        }

    }

    /*
     public void setPoints(double lifeDelta)
    {
        current += lifeDelat;
    }
    */

    public void SetGameState(string newState)
	{
		gameState = newState;
	}

}






