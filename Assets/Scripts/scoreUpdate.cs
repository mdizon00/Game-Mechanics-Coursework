using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreUpdate : MonoBehaviour
{
    public static scoreUpdate instance;

    public int scoreValue; 
    public TMP_Text scoreText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreValue.ToString() + " points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPointCoin() 
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString() + " points";
    }

    public void addPointItem() 
    {
        scoreValue = scoreValue + 5;
        scoreText.text = scoreValue.ToString() + " points";
    }
}

