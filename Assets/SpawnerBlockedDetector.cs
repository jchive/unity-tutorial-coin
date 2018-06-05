using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnerBlockedDetector : MonoBehaviour {
    public UnityEvent OnSpawnerBlocked = new UnityEvent();
    public UnityEvent OnSpawerClear = new UnityEvent();

    private void OnTriggerEnter(Collider other) {
        OnSpawnerBlocked.Invoke();
    }

    private void OnTriggerExit(Collider other) {
        OnSpawerClear.Invoke();
    }
}