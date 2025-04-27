using UnityEngine;
using System.Collections.Generic;


public class selectGlyph : MonoBehaviour {
    public List<string> glyphsSelected = new List<string>();
    private string glyphName = "";
    void Start()
    {

    }

    void Update()
    {

    }

    public void setGlyphStatus()
    {
        Debug.Log("setting status");
        Debug.Log(glyphName);
    }
}
