using UnityEngine;
using UnityEngine.UI;


public class selectRune : MonoBehaviour {
    public SpellComponentData rune;
    public Player player;
    public Toggle toggle;

    void Start()
    {
        // Fetch the Toggle GameObject
        toggle = GetComponent<Toggle>();

        // Add listener for when the state of the Toggle changes, to take action
        toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggle);
        });

        // Initialise the Text to say the first state of the Toggle
        // m_Text.text = "First Value : " + m_Toggle.isOn;
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        // m_Text.text =  "New Value : " + m_Toggle.isOn;
            Debug.Log("toggle on? RUNE! " + toggle.isOn);
            Debug.Log(rune.componentName);
        if (toggle.isOn) {
            player.AddRune(rune);
        } else {
            player.RemoveRune(rune);
        }
    }

    // public void setGlyphStatus()
    // {
    //     Debug.Log("setting status");
    //     Debug.Log(glyph.componentName);
    // }
}
