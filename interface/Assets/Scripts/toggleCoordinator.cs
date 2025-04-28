using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class toggleCoordinator : MonoBehaviour {
    public List<selectGlyph> glyphs;
    public List<selectRune> runes;
    public List<selectSpellSlot> spellSlots;
    public selectSpellSlot runeSlot;

    public void updateGlyphSlots() {
        foreach (selectSpellSlot glyph in spellSlots) {
            glyph.UpdateValues();
        }
    }
    public void updateRuneSlot() {
        runeSlot.UpdateValues();
    }
    public void updateGlyphPanel() {
        foreach (selectGlyph glyph in glyphs) {
            glyph.UpdateValues();
        }
    }
    public void updateRunePanel() {
        foreach (selectRune rune in runes) {
            rune.UpdateValues();
        }
    }
}