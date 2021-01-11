using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public bool isPlayArcade, isLevelSelect, isCharacterSelect, isSound, isExit, isBack, isLegacy;
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
        //SceneManager.LoadScene("Scene Name"); (can also use the index of the scene!)
        if (isPlayArcade) { SceneManager.LoadScene("ArcadeMode"); } 
        else if (isLevelSelect) { SceneManager.LoadScene("LevelSelect"); } 
        else if (isCharacterSelect) { SceneManager.LoadScene("CharacterSelect"); }
        else if (isSound) { SceneManager.LoadScene("SoundSelect"); } 
        else if (isExit) { Application.Quit(); }
        else if (isBack) { SceneManager.LoadScene("MainMenu"); }
        else if (isLegacy) {
        //    SceneManager.LoadScene("Legacy"); 
        }
    }
}
