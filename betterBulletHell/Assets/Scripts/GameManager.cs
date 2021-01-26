/*
 * This is the game manager for arcade mode. In arcade mode,
 * there will be random enemy swawns and the ocasional boss. 
 * The levels will not be pre-defined and there will be a score counter.
 * 
 * There may also be a slowly increasing game speed that is effected by using time scale.
 * 
 * Game manage will kep trace of score, killed enemies, (maybe ability usage), 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemyList; //Fill with prefabs


    // Start is called before the first frame update

    void Awake()
    {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 60;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
