using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[CreateAssetMenu]
public class SpellData : ScriptableObject {
    public Player player;
    public List<SpellComponentData> spellSlots;
    public int lockedGlyphSlots = 0;
    public int lockedRuneSlots = 0;
    public SpellComponentData runeSlot;  

    public void UpdateGlyphSlots(List<SpellComponentData> lockedGlyphs, List<SpellComponentData> selectedGlyphs)
    {
        Debug.Log("Updating glyphs!");
        spellSlots.Clear();
        lockedGlyphSlots = 0;
        var j = 0;
        // we hard-coded the length here, but this can change in a future version
        for (var i = 0; i < 5; i++) {
            // spellSlots[i].setSlotText("empty");
            if (lockedGlyphs.Count > i) {
                spellSlots.Add(lockedGlyphs[i]); // .setSlotText(lockedGlyphs[i].componentName + "<br>(spent!)");
                lockedGlyphSlots++;
            } else if (selectedGlyphs.Count > j) {
                spellSlots.Add(selectedGlyphs[j]); // .setSlotText(selectedGlyphs[j].componentName);
                j++;
            }
        }
    }
    public void UpdateRuneSlots(List<SpellComponentData> lockedRunes, List<SpellComponentData> selectedRunes)
    {
        // for now, we only allow a single rune - if I build on this later I will want to mimic the functionality above in UpdateGlyphSlots
        runeSlot = null;
        lockedRuneSlots = 0;
        if (lockedRunes.Count > 0) {
            runeSlot = lockedRunes[0]; // .setSlotText(lockedRunes[0].componentName + "<br>(spent!)");
            lockedRuneSlots = 1;
        } else if (selectedRunes.Count > 0) {
            runeSlot = selectedRunes[0]; // .setSlotText(selectedRunes[0].componentName);
        }
    }
}
