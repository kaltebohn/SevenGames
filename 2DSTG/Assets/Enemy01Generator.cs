using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01Generator : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private static readonly float GENERATION_TIMESPAN = 3.0f;
    private static readonly float GENERATION_POSITION_X = 12.0f;
    private static readonly float GENERATION_POSITION_Y_MIN = -4.0f;
    private static readonly float GENERATION_POSITION_Y_MAX = 4.0f;

    private float deltaTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += Time.deltaTime;
        if (deltaTime > GENERATION_TIMESPAN)
        {
            deltaTime = 0;
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = new Vector3
                (
                    GENERATION_POSITION_X,
                    Random.Range(GENERATION_POSITION_Y_MIN, GENERATION_POSITION_Y_MAX),
                    0
                );
        }
    }
}
