using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectItem : MonoBehaviour

{
    public GameObject collectable;
    public double points;
    public int life = 0;

    private GameManager gameplayManager;


    void Awake()
     {
        gameplayManager = FindObjectOfType<GameManager>();
     }

    public double GetPoints()
    {
        return points;
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            collision.GetComponent<Bat>().currentHealth += 5;
            life = collision.GetComponent<Bat>().currentHealth;
            gameplayManager.UpdateLife(life);
        }
    }
    

}


