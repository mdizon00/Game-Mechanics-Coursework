using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public EnemyMovement enemyMovement;

    public GameManager gameManager;
    private bool isDead;

    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        isDead = false;
    }

    // Update is called once per frame
    void Update(){
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1); //health bar fill reflects player health
    }

    public void Damage(float damage)
    {
        health -= damage; //player takes damage

        if(health <= 0 && !isDead)
        {
            healthBar.fillAmount = 0; //bar has no fill
            endGame(); //method is run
        }
    }

    //end game runs game over screen from game manager
    public void endGame(){
        isDead = true;
        enemyMovement.isChasing = false; //enemy stops chasing
        Destroy(gameObject); //destroys player object
        gameManager.gameOver(); //game manager script
    }
}
