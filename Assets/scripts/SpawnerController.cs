using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

	public GameObject ObjectToSpawn;
	public Transform SpawnLocation;

	public CoinEvent OnSpawnCoin = new CoinEvent();

	public bool spawnerBlocked = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1")) {
			SpawnObject();			
		}

	}
	
	void SpawnObject() {
		if (!spawnerBlocked) {
			var coin = Instantiate(ObjectToSpawn, transform);
			coin.transform.position = SpawnLocation.position;
			coin.transform.rotation = SpawnLocation.rotation;

			OnSpawnCoin.Invoke();
		}
	}

	public void SetSpawnerBlocked(bool value) {
		spawnerBlocked = value;
	}

	

}

