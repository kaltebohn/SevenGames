using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01BulletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject enemyBulletPrefab;
    private static readonly float GENERATION_TIMESPAN_BASE = 1.0f;
    private static readonly float GENERATION_TIME_EPSILON = 0.3f;

    private float generationTimespan;
    private float deltaTime = 0;

    // Start is called before the first frame update
    void Start()
    {   
        /* 登場直後は早めに撃てるようにしてやる。 */
        generationTimespan = GENERATION_TIME_EPSILON * Random.Range(0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        /* 一定間隔で確率的に弾を生成する。 */
        deltaTime += Time.deltaTime;
        if (deltaTime > generationTimespan)
        {
            deltaTime = 0;
            /* ある程度一定の間隔で弾を撃つようにするが、多少ばらつかせる。 */
            generationTimespan = GENERATION_TIMESPAN_BASE + GENERATION_TIME_EPSILON * Random.Range(-1.0f, 1.0f);

            GameObject enemy = Instantiate(enemyBulletPrefab);
            enemy.transform.position = transform.position;
        }
    }
}
