using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float potential = 12;
    public float comfort = 100;
    public float staminaThreshold = 120;
    public float deathHealth = 50;
    public float runeLimit = 1;
    public List<string> glyphsSelected = new List<string>();
    public List<string> runesSelected = new List<string>();
}
