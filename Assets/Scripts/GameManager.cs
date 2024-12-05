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

    // Update is called once per frame
    void Update()
    {

    }

    public void gameOver(){
        gameOverUI.SetActive(true);
        Debug.Log("game over");
    }

    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void menu(){
        SceneManager.LoadScene("Menu");
    }
}
