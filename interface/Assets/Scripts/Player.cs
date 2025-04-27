using UnityEngine;

[CreateAssetMenu]
public class Player : ScriptableObject
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

    public void SpendSpellComponents()
    {
        // loop over current glyphsSelected and runesSelected
        // spend values
        // lock those components and their slots in the spell viewer
    }

    public void EndTurn()
    {
        SpendSpellComponents();

        // we get potential back when our turn ends
        playerData.potential = playerData.maxPotential;
    }

    public void CastSpell()
    {
        SpendSpellComponents();

        // unlock all glyphs and runes, clear the spell viewer
    }

}