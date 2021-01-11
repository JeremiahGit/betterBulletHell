using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
 * I want to add a pause menu. Everything will freeze, potentially use a universal speed and time multiplier to set everything to zero. 
 */
public class PauseButton : MonoBehaviour
{
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
        SceneManager.LoadScene("MainMenu");
    }
}
