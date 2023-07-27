using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static readonly float MOVE_SPEED = 8.0f;
    private static readonly float X_MOVE_LIMIT = 10.0f;
    private static readonly float Y_MOVE_LIMIT = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        /* プラットフォームのデフォルト値に合わせる。 */
        Application.targetFrameRate = -1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDir = Vector2.zero;
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -X_MOVE_LIMIT)
        {
            moveDir += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= X_MOVE_LIMIT)
        {
            moveDir += Vector2.right;
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -Y_MOVE_LIMIT)
        {
            moveDir += Vector2.down;
        }
        if (Input.GetKey(KeyCode.W) && transform.position.y <= Y_MOVE_LIMIT)
        {
            moveDir += Vector2.up;
        }
        GetComponent<Rigidbody2D>().velocity = MOVE_SPEED * moveDir.normalized;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
