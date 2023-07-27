using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject playerBulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject playerBullet = Instantiate(playerBulletPrefab);
            playerBullet.transform.position = transform.position;
        }
    }
}
