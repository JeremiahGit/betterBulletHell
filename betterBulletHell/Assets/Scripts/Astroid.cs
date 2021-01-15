using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    
    private Rigidbody2D rb;
    public float xLeftBound; 
    public float xRightBound;
    public float yLevel;

    public Sprite warning;
    public Sprite astroidOne;
    public Sprite astroidTwo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(Random.Range(xLeftBound, xRightBound), yLevel);

        int selector = Random.Range(0, 2);
        if (selector == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = astroidOne;
        }
        else 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = astroidTwo;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
