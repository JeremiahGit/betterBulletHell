using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationManager : MonoBehaviour
{
    static bool isTheOneAndOnlyTrueInformationManager = false;
    private static byte selectedCharacter = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (isTheOneAndOnlyTrueInformationManager != true)
        {
            isTheOneAndOnlyTrueInformationManager = true;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void changePlayerRight() { selectedCharacter += 1; Debug.Log(selectedCharacter); }
    public void changePlayerLeft()  { selectedCharacter -= 1; }
}
