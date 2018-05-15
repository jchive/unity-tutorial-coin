using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCollidingObject : MonoBehaviour {

    public CoinEvent OnDestroyCoin = new CoinEvent();
    
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(other.gameObject);
        
        OnDestroyCoin.Invoke();
    }
}