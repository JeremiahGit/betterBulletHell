using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public bool isPlayArcade, isLevelSelect, isCharacterSelect, isSound, isExit, isBack, isLegacy,
                isRightPlayerSelectArrow, isLeftPlayerSelectArrow;

    //TODO not be dum 
    //public InformationManager info = new(InformationManager);
    private void OnMouseUp()
    {
        //If I make my code look pretty maybe they will give me a raise!!!!!
        //SceneManager.LoadScene("Scene Name"); (can also use the index of the scene!)
        if      (isPlayArcade)      { SceneManager.LoadScene("ArcadeMode");      }
        else if (isLevelSelect)     { SceneManager.LoadScene("LevelSelect");     }
        else if (isCharacterSelect) { SceneManager.LoadScene("CharacterSelect"); }
        else if (isSound)           { SceneManager.LoadScene("SoundSelect");     }
        else if (isExit)            { Application.Quit();                        }
        else if (isBack)            { SceneManager.LoadScene("MainMenu");        }
        else if (isLegacy)          {/*SceneManager.LoadScene("Legacy");*/       }

        else if (isRightPlayerSelectArrow) { /* info.changePlayerRight(); */ }
        else if (isLeftPlayerSelectArrow)  {/* info.changePlayerLeft();  */  }
    }
}
