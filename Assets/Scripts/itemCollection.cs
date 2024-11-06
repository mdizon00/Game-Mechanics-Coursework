using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {

        scoreUpdate.instance.addPointItem();

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
