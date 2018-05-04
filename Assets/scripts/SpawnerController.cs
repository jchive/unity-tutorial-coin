using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

	public GameObject ObjectToSpawn;

	private float startTime;
	
	// Use this for initialization
	void Start () {

		startTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time - startTime > 1.0f) {
			SpawnObject();
			startTime = Time.time;
		}

	}
	
	void SpawnObject() {
		var coinInstance = Instantiate(ObjectToSpawn, transform);

		var position = coinInstance.transform.localPosition;

		position.x = Random.Range(-2.5f, 2.5f);

		coinInstance.transform.localPosition = position;
	}


}

