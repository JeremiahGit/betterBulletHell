using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50;
    public float fireRate = 1;
    private float xinput, yinput;

    private Rigidbody2D rb;
    private GameManager gm;
    public GameObject bullet;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void FixedUpdate()
    {
        //Movement and Player Input
        xinput = Input.GetAxis("Horizontal");
        yinput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xinput * speed * Time.deltaTime, yinput * speed * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            StartCoroutine("ShootLoop");
        }
    }

    IEnumerator ShootLoop()
    {
        Instantiate(bullet, rb.position, Quaternion.Euler(0, 0, 0));
        yield return new WaitForSeconds(fireRate * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
