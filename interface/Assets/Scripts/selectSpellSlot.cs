using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class selectSpellSlot : MonoBehaviour {
    private SpellComponentData spellComponent;
    public Player player;
    public SpellData spell;
    public Toggle toggle;
    public TMP_Text text;
    public int slotIndex; // = 0;
    public bool isRune = false;
    public toggleCoordinator coordinator;

    void Start()
    {
        // Fetch the Toggle GameObject
        toggle = GetComponent<Toggle>();

        // Add listener for when the state of the Toggle changes, to take action
        toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggle);
        });
        // text = GetComponent<TMP_Text>();
        // Initialise the Text to say the first state of the Toggle
        // m_Text.text = "First Value : " + m_Toggle.isOn;
        UpdateValues();
    }

    public void Update() {
        UpdateValues();
    }

    public void UpdateValues() {
        Debug.Log("updating.......");
        if (slotIndex > -1 && slotIndex < 5) {
            var locked = false;
            var enabled = false;
            if (isRune && slotIndex == 0) {
                if (spell.runeSlot) {
                    spellComponent = spell.runeSlot;
                    if (spell.lockedRuneSlots != 0) {
                        locked = true;
                    } else {
                        enabled = true;
                    }
                }
            } else {
                Debug.Log("" + spell.spellSlots.Count + " " + slotIndex);
                if (spell.spellSlots.Count > slotIndex) {
                    spellComponent = spell.spellSlots[slotIndex];
                    if (slotIndex < spell.lockedGlyphSlots) {
                        locked = true;
                    } else {
                        enabled = true;
                    }
                }
            }
            if (locked) {
                Debug.Log("LOCKED!");
                setSlotText(spellComponent.componentName + "<br>(spent!)");
                lockSlot(true);
            } else if (enabled) {
                Debug.Log("ENABLED!");
                setSlotText(spellComponent.componentName);
                enableSlot(true);
            } else {
                Debug.Log("DISABLED!");
                setSlotText("empty");
                enableSlot(false);
            }
            
        }
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        // m_Text.text =  "New Value : " + m_Toggle.isOn;
        Debug.Log("toggle on? SPELL SLOT!" + toggle.isOn);
        Debug.Log(spellComponent.componentName);

        if (toggle.isOn) {
            // player.AddGlyph(glyph);
        } else {
            if (isRune) {
                player.RemoveRune(spellComponent);
                coordinator.updateRunePanel();
            } else {
                player.RemoveGlyph(spellComponent);
                coordinator.updateGlyphPanel();
            }
        }
    }

    public void setSlotText(string spellComponentName)
    {   
        
        Debug.Log("Setting text to: " + spellComponentName);
        text.text = spellComponentName;
    }

    public void enableSlot(bool enableThisSlot)
    {
        toggle.interactable = enableThisSlot;
        toggle.isOn = enableThisSlot;
        // if (enableThisSlot) {
        //     this.enabled = true
        // } else {
            
        // }
    }

    public void lockSlot(bool lockThisSlot)
    {
        toggle.interactable = !lockThisSlot;
        toggle.isOn = lockThisSlot;
    }
}
