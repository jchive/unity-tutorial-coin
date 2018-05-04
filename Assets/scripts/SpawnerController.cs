using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

	public GameObject ObjectToSpawn;
	public Transform SpawnLocation;

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
		var coin = Instantiate(ObjectToSpawn, transform);
		coin.transform.position = SpawnLocation.position;
	}

}

