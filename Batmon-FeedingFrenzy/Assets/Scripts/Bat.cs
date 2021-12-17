using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bat : MonoBehaviour
{
    public AudioSource BatWing;

    public Animator animator;


    public int maxHealth = 100;
    public int currentHealth;

    public GameManager gameManager;

    public HealthBar healthBar;

    //Movement speed
    public float speed = 2;

    //Flap force
    public float force = 300;
    private string gameState;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);


        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
        //Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetFloat("speed", speed);

        //Flap
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            TakeDamage(2);
            BatWing.Play();
            gameManager.UpdateLife(currentHealth);
        }
        
    }

    //void OnCollsionEnter2D(Collision2D collision)
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("border"))
        {

            currentHealth = 0;
            Debug.Log("border trigger");
            gameManager.SetGameState("Game Over");

        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);


    }



}