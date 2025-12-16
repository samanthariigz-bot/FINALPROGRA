using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "WaveConfig", menuName = "WaveSystem/WaveConfig")]
public class WaveConfig : ScriptableObject
{
    public string waveName;
    public List<WaveEntry> entries = new List<WaveEntry>();
    public float delayBeforeStart = 1f;
    public float delayAfterWave = 2f;
}