/* 
 * The player bullet script.
 * This controls the movement of the bullet.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerBullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public float speedMod = 50f;
    private Rigidbody2D bulletRB;


    /*
     * Start is called before the first frame update
     * Sets velocity of bullet
     */
    void Start()
    {
        bulletRB = gameObject.GetComponent<Rigidbody2D>();
        bulletRB.velocity = new Vector2(0, bulletSpeed * speedMod * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }


    /*
     * Only impacts with the border and the enemies. Not their bullets.
     */
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
