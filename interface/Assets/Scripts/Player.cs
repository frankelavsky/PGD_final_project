using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData playerData;

    void Update()
    {
        // our data = thing that has changed
        // playerData.currentPosition = transform.position;
    }

    public void AddGlyph(SpellComponentData glyphToAdd)
    {
        playerData.glyphsSelected.Add(glyphToAdd);
    }

    public void RemoveGlyph(SpellComponentData glyphToRemove)
    {
        playerData.glyphsSelected.Remove(glyphToRemove);
    }

    public void AddRune(SpellComponentData runeToAdd)
    {
        if (playerData.runesSelected.Count <= playerData.runeLimit) {
            playerData.runesSelected.Add(runeToAdd);
        }
    }

    public void RemoveRune(SpellComponentData runeToRemove)
    {
        playerData.runesSelected.Remove(runeToRemove);
    }

    public void AdjustState(string stateName, int adjustment)
    {
        var propertyInfo = playerData.GetType().GetProperty(stateName);
        if (propertyInfo == null) return;
        propertyInfo.SetValue(playerData, adjustment);
    }

}