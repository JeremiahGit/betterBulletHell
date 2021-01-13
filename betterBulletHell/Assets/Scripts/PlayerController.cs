using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6;
    public float speedMod = 50;
    public float fireRate = .075f;
    private float xinput, yinput;

    private bool isShooting = false;

    private Rigidbody2D rb;
    private GameManager gm;
    public GameObject bullet;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        fireRate = .075f;//This is necessasary because otherwise the bullets dont work properly \_(:/)_/
    }

    void FixedUpdate()
    {
        //Movement and Player Input
        xinput = Input.GetAxis("Horizontal");
        yinput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xinput * speed * speedMod * Time.deltaTime, yinput * speed * speedMod * Time.deltaTime); //x,y

        if (Input.GetKeyDown("space"))
        {
            StartCoroutine("ShootLoop");
        }
    }

    IEnumerator ShootLoop()
    {
        if (!isShooting)
        {
            isShooting = true;
            while (Input.GetKey("space"))
            {
                for (int i = 0; i < 3; i++)
                {
                    Instantiate(bullet, rb.position, Quaternion.Euler(0, 0, 0));
                    yield return new WaitForSeconds(fireRate); //Yes, I know there is no Time.deltaTime here
                }
                yield return new WaitForSeconds(fireRate * 3.5f);
            }
            isShooting = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
