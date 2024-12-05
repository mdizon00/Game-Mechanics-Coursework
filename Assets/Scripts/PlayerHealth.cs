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

    void Update(){
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }

    public void Damage(float damage)
    {
        health -= damage;

        if(health <= 0 && !isDead)
        {
            healthBar.fillAmount = 0;
            endGame();
        }
    }

    public void endGame(){
        isDead = true;
        enemyMovement.isChasing = false;
        Destroy(gameObject);
        gameManager.gameOver();
    }
}
