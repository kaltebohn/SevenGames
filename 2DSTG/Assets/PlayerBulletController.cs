using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    private static readonly float SHOOT_SPEED =10.0f;
    private static readonly float X_VISIBLE_LIMIT = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = SHOOT_SPEED * Vector2.right;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > X_VISIBLE_LIMIT)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
