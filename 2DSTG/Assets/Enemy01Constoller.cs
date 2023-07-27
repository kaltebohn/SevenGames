using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01Constoller : MonoBehaviour
{
    private static readonly float MOVE_SPEED = 8.0f;
    private static readonly float X_VISIBLE_LIMIT = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = MOVE_SPEED * Vector2.left;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -X_VISIBLE_LIMIT)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(gameObject);
        }
    }
}
