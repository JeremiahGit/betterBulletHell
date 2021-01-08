using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public bool isPlayArcade, isLevelSelect, isCharacterSelect, isSound, isExit, isBack;
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
        //Application.LoadLevel("Scene Name"); (can also use the index of the scene!)
        if (isPlayArcade) { Application.LoadLevel("ArcadeMode"); } 
        else if (isLevelSelect) { Application.LoadLevel("LevelSelect"); } 
        else if (isCharacterSelect) { Application.LoadLevel("CharacterSelect"); }
        else if (isSound) { Application.LoadLevel("SoundSelect"); } 
        else if (isExit) { Application.Quit(); }
        else if (isBack) { Application.LoadLevel("MainMenu"); }
    }
}
