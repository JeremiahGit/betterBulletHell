using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public bool isPlayArcade, isLevelSelect, isCharacterSelect, isSound, isExit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        if (isPlayArcade) { } //Application.LoadLevel(1);
        else if (isLevelSelect) { } //Application.LoadLevel(1);
        else if (isCharacterSelect) { } //Application.LoadLevel(1);
        else if (isSound) { } //Application.LoadLevel(1);
        else if (isExit) { Application.Quit(); }
    }
}
