using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The astroid enemy. I need to have a custom spawn position for this emeny in order to make it spawn on screen instead of off screen.
 * This is because the spawn manager spawns enemy off screen. This is by design.   ≥.≤
 * 
 */
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
    private float desiredScale = .2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Renderer>().enabled = true;
        //rb.transform.localScale = new Vector3(.1f, .1f, .1f);
        transform.position = new Vector3(Random.Range(xLeftBound, xRightBound), yLevel);
        gameObj = this.gameObject;

        StartCoroutine("BusinessCat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destroyGameObject()
    {
        ///Score Increment Here
        Destroy(this.gameObject);
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
        transform.localScale = new Vector3(desiredScale, desiredScale, desiredScale);
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

        yield return new WaitForSeconds(4);
        destroyGameObject();
        yield return null;
    }

}