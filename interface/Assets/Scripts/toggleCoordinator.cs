using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class toggleCoordinator : MonoBehaviour {
    public List<selectSpellSlot> spellSlots;
    public selectSpellSlot runeSlot;

    public void updateGlyphSlots() {
        foreach (selectSpellSlot spell in spellSlots) {
            spell.UpdateValues();
        }
    }
    public void updateRuneSlot() {
        runeSlot.UpdateValues();
    }
    public void updateGlyphPanel() {
        foreach (selectSpellSlot spell in spellSlots) {
            spell.UpdateValues();
        }
    }
    public void updateRunePanel() {
        runeSlot.UpdateValues();
    }
}