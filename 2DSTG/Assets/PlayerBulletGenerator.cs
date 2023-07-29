using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject playerBulletPrefab;
    private static readonly float AUTO_FIRING_TIMESPAN = 0.3f;

    private bool isAutoMode = false;
    public bool IsAutoMode
    {
        get => isAutoMode;
    }
    private float deltaTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAutoMode)
        {
            deltaTime += Time.deltaTime;
            if (deltaTime > AUTO_FIRING_TIMESPAN)
            {
                deltaTime = 0;
                Generate();
            }
        }
        else
        {
            /* 自動射撃モードに切り替えてから射撃までの間隔を一定にしたいので、
             * 自動射撃モードでないときは経過時間をリセット。 */
            deltaTime = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Generate();
            }
        }
    }

    public void InvertMode()
    {
        isAutoMode = !isAutoMode;
    }

    void Generate()
    {
        GameObject playerBullet = Instantiate(playerBulletPrefab);
        playerBullet.transform.position = transform.position;
    }
}
