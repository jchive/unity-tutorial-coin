using UnityEngine;

public class InitialCoinSpawner : MonoBehaviour {
    public GameObject spawnObject;
    public int numberToSpawn = 50;
    public Transform spawnContainer;

    private void Start() {
        gameObject.SetActive(false);

        var cubeBoundary = GetComponent<Renderer>().bounds;


        var temporarySpawn = Instantiate(spawnObject);
        var spawnBounds = temporarySpawn.GetComponent<Renderer>().bounds;
        var size = spawnBounds.size / 2.0f;

        var spawnMinimum = cubeBoundary.min + size / 2.0f;
        var spawnMaximum = cubeBoundary.max - size / 2.0f;

        Destroy(temporarySpawn);

        for (var i = 0; i < numberToSpawn; ++i) {
            var position = new Vector3(
                Random.Range(spawnMinimum.x, spawnMaximum.x),
                Random.Range(spawnMinimum.y, spawnMaximum.y),
                Random.Range(spawnMinimum.z, spawnMaximum.z)
            );

            temporarySpawn = Instantiate(spawnObject, spawnContainer);
            temporarySpawn.transform.position = position;
        }
    }
}