using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerController : MonoBehaviour {
    public GameObject ObjectToSpawn;
    public Transform SpawnLocation;

    public float velocityJitter = 1.0f;
    public float angularVelocityJitter = 10.0f;

    public CoinEvent OnSpawnCoin = new CoinEvent();

    public bool spawnerBlocked = false;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            SpawnObject();
        }
    }

    void SpawnObject() {
        if (!spawnerBlocked) {
            var coin = Instantiate(ObjectToSpawn, transform);
            coin.transform.position = SpawnLocation.position;
            coin.transform.rotation = SpawnLocation.rotation;

            var coinRigidbody = coin.GetComponent<Rigidbody>();

            coinRigidbody.angularVelocity =
                Random.Range(-angularVelocityJitter, angularVelocityJitter) * coin.transform.up;

            coinRigidbody.velocity =
                coin.transform.forward * Random.Range(-velocityJitter, velocityJitter)
                +
                coin.transform.right * Random.Range(-velocityJitter, velocityJitter)
                ;


            OnSpawnCoin.Invoke();
        }
    }

    public void SetSpawnerBlocked(bool value) {
        spawnerBlocked = value;
    }
}