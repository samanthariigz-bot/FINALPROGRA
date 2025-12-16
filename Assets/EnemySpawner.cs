using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Configuración del Spawner")]
    public GameObject enemyPrefab;         
    public int numeroDeOleadas = 3;        
    public int enemigosPorOleada = 5;      

    [Header("Tiempos de Control")]
    public float tiempoEntreEnemigos = 0.5f;   
    public float tiempoEntreOleadas = 2f;      

    private void Start()
    {
        StartCoroutine(GenerarOleadas());
    }

    IEnumerator GenerarOleadas()
    {
        for (int i = 0; i < numeroDeOleadas; i++)
        {
            Debug.Log("Oleada " + (i + 1));

            for (int j = 0; j < enemigosPorOleada; j++)
            {
                Instantiate(enemyPrefab, transform.position, Quaternion.identity);

                yield return new WaitForSeconds(tiempoEntreEnemigos);
            }

            if (i < numeroDeOleadas - 1)
                yield return new WaitForSeconds(tiempoEntreOleadas);
        }
    }
}