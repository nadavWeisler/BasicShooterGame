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
		var enemyNum = UnityEngine.Random.Range(1, 4);
		switch(enemyNum) {
			case 1: 
				Instantiate(enemy1, 
					new Vector3(UnityEngine.Random.Range(-10, 10), 0, UnityEngine.Random.Range(-10, 10)), 
					Quaternion.identity);
				break;
			case 2: 
				Instantiate(enemy2, 
					new Vector3(UnityEngine.Random.Range(-10, 10), 0, UnityEngine.Random.Range(-10, 10)), 
					Quaternion.identity);
			break;
			default:
				Instantiate(enemy3, 
					new Vector3(UnityEngine.Random.Range(-10, 10), 0, UnityEngine.Random.Range(-10, 10)), 
					Quaternion.identity);
			break;
		}      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}