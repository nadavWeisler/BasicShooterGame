using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class EnemyProducer : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    [SerializeField] private DateTime lastUpdate;

    void Start()
    {
	    lastUpdate = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
	    if (DateTime.Now.Second - lastUpdate.Second >= 1)
	    {
		    var i = UnityEngine.Random.Range(0, this.enemies.Length);
		    Instantiate(enemies[i],
			    new Vector3(UnityEngine.Random.Range(-10, 10), 0, UnityEngine.Random.Range(-10, 10)),
			    Quaternion.identity);
		    lastUpdate = DateTime.Now;
	    }
    }
}