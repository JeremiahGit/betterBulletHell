using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float bulletSpeed = 4f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-bulletSpeed * Mathf.Sin(Mathf.Abs(rb.transform.rotation.eulerAngles.z * Mathf.Deg2Rad)), bulletSpeed * Mathf.Cos(Mathf.Abs(rb.transform.rotation.eulerAngles.z * Mathf.Deg2Rad)));
    }

    // Update is called once per frame  
    void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }

}
