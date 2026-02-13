using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Transform[] spawnPoints;

    private Wave wave;
    private int spawnedEnemies = 0;
    private float nextSpawnTime = 0f;

    public void ChangeWave(Wave wave)
    {
        this.wave = wave;
        spawnedEnemies = 0;
        nextSpawnTime = Time.time;
    }

    public bool IsComplete()
    {
        return spawnedEnemies >= wave.enemyCount;
    }


    void Update()
    {
        float t = Time.time;

        if (spawnedEnemies < wave.enemyCount && t > nextSpawnTime)
        {
            Spawn();
            spawnedEnemies++;
            nextSpawnTime = t + wave.spawnInterval;
        }
        
    }

    void Spawn()
    {
        int enemyIndex = Random.Range(0, wave.enemyPrefabs.Length);
        int pointIndex = Random.Range(0, spawnPoints.Length);

        var prefabs = wave.enemyPrefabs[enemyIndex];
        var points = spawnPoints[pointIndex];

        Instantiate(prefabs, points.position, Quaternion.Euler(0, 180, 0));
        
    }
}
