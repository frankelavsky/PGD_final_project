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
    public List<SpellComponentData> glyphsSelected = new List<SpellComponentData>();
    public List<SpellComponentData> runesSelected = new List<SpellComponentData>();
}
