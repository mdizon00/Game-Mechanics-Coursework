using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollection : MonoBehaviour
{

    private int score;


    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other) {

        scoreUpdate.instance.addPointCoin();

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }



}
