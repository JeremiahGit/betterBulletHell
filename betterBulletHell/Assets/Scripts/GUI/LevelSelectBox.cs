using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelectBox : MonoBehaviour
{
    private Vector3 increasedSize, originalSize;
    public int LevelNumber;
    // Start is called before the first frame update
    void Start()
    {
        increasedSize = new Vector3(0.28f, 0.28f, 0.28f);
        originalSize = new Vector3(.25f, .25f, .25f);
        LevelNumber += 4; //This +4 is to account for the Main Menu & Arcade Scenes
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        transform.localScale = increasedSize;
    }

    private void OnMouseExit()
    {
        transform.localScale = originalSize;
    }

    private void OnMouseUp()
    {
        SceneManager.LoadScene(LevelNumber);
    }
}