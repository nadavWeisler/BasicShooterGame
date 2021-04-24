using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProducer : MonoBehaviour
{
    [SerializeField] private GameObject enemy1;

    [SerializeField] private GameObject enemy2;

    [SerializeField] private GameObject enemy3;

    // Start is called before the first frame update
    void Start()
    {
        Player currentPlayer = gameObject.GetComponent<Player>();
        Enemy enemy = Instantiate(enemy1).GetComponent<Enemy>();
        Instantiate(enemy2);
        Instantiate(enemy3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}