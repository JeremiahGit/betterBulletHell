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

    public GameObject gameObj;
    public float flashTime;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Renderer>().enabled = true;
        transform.position = new Vector3(Random.Range(xLeftBound, xRightBound), yLevel);
        gameObj = this.gameObject;

        StartCoroutine("BusinessCat");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BusinessCat()
    {
        for (int i = 0; i <= 3; i++)
        {
            yield return new WaitForSeconds(flashTime);
            gameObj.GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(flashTime);
            gameObj.GetComponent<Renderer>().enabled = true;
        }

        transform.position = new Vector3(rb.position.x, rb.position.y+2f);
        rb.velocity = new Vector2(0, -speed);
        int selector = Random.Range(0, 2);
        if (selector == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = astroidOne;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = astroidTwo;

        }
            yield return null;
    }

}