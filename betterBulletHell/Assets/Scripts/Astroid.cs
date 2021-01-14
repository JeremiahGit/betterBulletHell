using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    
    private Rigidbody2D rb;
    public float xLeftBound; 
    public float xRightBound;
    public float yLevel;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(Random.Range(xLeftBound, xRightBound), yLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
