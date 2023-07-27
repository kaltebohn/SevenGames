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
        /* �o�꒼��͑��߂Ɍ��Ă�悤�ɂ��Ă��B */
        generationTimespan = GENERATION_TIME_EPSILON * Random.Range(0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        /* ���Ԋu�Ŋm���I�ɒe�𐶐�����B */
        deltaTime += Time.deltaTime;
        if (deltaTime > generationTimespan)
        {
            deltaTime = 0;
            /* ������x���̊Ԋu�Œe�����悤�ɂ��邪�A�����΂������B */
            generationTimespan = GENERATION_TIMESPAN_BASE + GENERATION_TIME_EPSILON * Random.Range(-1.0f, 1.0f);

            GameObject enemy = Instantiate(enemyBulletPrefab);
            enemy.transform.position = transform.position;
        }
    }
}
