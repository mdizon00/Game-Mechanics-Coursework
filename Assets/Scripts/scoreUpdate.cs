using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class scoreUpdate : MonoBehaviour
{
    public static scoreUpdate instance;

    public int scoreValue;
    public TMP_Text scoreText;
    public Image arrow;

    public GameObject next;

    //creates the score board
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreValue.ToString() + " points"; //text displays "0 points"
        arrow.gameObject.SetActive(false); //arrow pointing to next level is hidden
    }

    // Update is called once per frame
    void Update()
    {
        //checks if all items and coins have been collected before player can move on
        if (scoreValue >= 18){
            next.SetActive(true); //trigger for next level appears
            arrow.gameObject.SetActive(true); //arrow to guide player appears
        }
    }

    //when coin is collected
    public void addPointCoin()
    {
        scoreValue = scoreValue + 1;
        scoreText.text = scoreValue.ToString() + " points"; //score updates
    }

    //when food is collected
    public void addPointItem()
    {
        scoreValue = scoreValue + 5;
        scoreText.text = scoreValue.ToString() + " points"; //score updates
    }
}
