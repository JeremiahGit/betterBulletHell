/* 
 * The player control script. This includes movement and fireing.
 * The controls for movement are WASD / Arrow Keys.
 * The control for shooting is spacebar.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed = 6;
    private float speedMod;
    private float fireRate;
    private float xinput, yinput;

    private bool isShooting = false;

    private Rigidbody2D rb;
    private GameManager gm;
    public GameObject bullet;

    /*
     * 
     */
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        //This is necessasary because otherwise the bullets dont work properly \_(:/)_/
        fireRate = 5;
        speedMod = 50f;
    }

    /* 
     * Movement and shooting are controlled in FixedUpdate()
     */
    void FixedUpdate()
    {
        //Movement and Player Input
        xinput = Input.GetAxis("Horizontal");
        yinput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xinput * speed * speedMod * Time.deltaTime, yinput * speed * speedMod * Time.deltaTime); //x,y

        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(ShootLoop());
        }
    }

    /*
     * The default shooting pattern for the player.
     * Shoots burst fire projectiles that travel in a line.
     * Does not allow more bullets by spamming the fire button.
     */
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
                    yield return WaitFor.Frames(3);
                }
                yield return WaitFor.Frames( (int)fireRate*5 );
            }
            isShooting = false;
        }
    }

    /* 
     * The player dies if the hitbox enters anything beside's it's own bullet or ability. 
     * TODO: make death GUI
     */
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("PlayerSpawn"))
        {
            Destroy(gameObject);
        }
    }
    public static class WaitFor
    {
        public static IEnumerator Frames(int frameCount)
        {
            while (frameCount > 0)
            {
                frameCount--;
                yield return null;
            }
        }
    }

}
