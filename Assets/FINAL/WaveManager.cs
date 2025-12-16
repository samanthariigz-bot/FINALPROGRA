using System.Collections;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public WaveConfig[] waves;
    public Transform[] spawnPoints;
    public float timeBetweenWaves = 5f;

    int currentWave = 0;

    void Start()
    {
        StartCoroutine(WaveLoop());
    }

    IEnumerator WaveLoop()
    {
        while (currentWave < waves.Length)
        {
            yield return new WaitForSeconds(timeBetweenWaves);
            yield return StartCoroutine(SpawnWave(waves[currentWave]));
            currentWave++;
        }
    }

    IEnumerator SpawnWave(WaveConfig wave)
    {
        foreach (var entry in wave.entries)
        {
            for (int i = 0; i < entry.count; i++)
            {
                Transform sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
                Instantiate(entry.enemyProfile.prefab, sp.position, sp.rotation);
                yield return new WaitForSeconds(entry.spawnInterval);
            }
        }
    }
}