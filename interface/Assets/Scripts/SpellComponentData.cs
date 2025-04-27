using UnityEngine;

[CreateAssetMenu]
public class SpellComponentData : ScriptableObject
{
    // public bool toggled = false;
    public string componentName;
    public string componentType;

    public float potentialCost;
    public float comfortCost;
    public float staminaThresholdCost;
    public float deathHealthCost;

    public string shortAddRemoveDescription;
}
