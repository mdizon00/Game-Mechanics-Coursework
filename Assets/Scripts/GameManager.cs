using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
    }

    //death screen is displayed
    public void gameOver(){
        gameOverUI.SetActive(true);
        Debug.Log("game over");
    }

    //loads scene again
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //goes to menu screen
    public void menu(){
        SceneManager.LoadScene("0_Menu");
    }

    //goes to level 1
    public void play(){
        SceneManager.LoadScene("1_Must Requirements");
    }
}
