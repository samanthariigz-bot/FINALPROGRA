using UnityEngine;

[CreateAssetMenu(fileName = "EnemyProfile", menuName = "WaveSystem/EnemyProfile")]
public class EnemyProfile : ScriptableObject
{
    public string enemyName;
    public GameObject prefab;
    public int maxHealth = 10;
    public float speed = 3f;
    public int reward = 1;
}