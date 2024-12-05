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

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreValue.ToString() + " points";
        arrow.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue >= 18){
            next.SetActive(true);
            arrow.gameObject.SetActive(true);
        }
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
