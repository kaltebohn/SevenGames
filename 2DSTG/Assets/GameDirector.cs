using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameDirector : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject autoModeText;
    [SerializeField] private GameObject playerBulletGenerator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && player != null)
        {
            if (playerBulletGenerator.GetComponent<PlayerBulletGenerator>().IsAutoMode)
            {
                autoModeText.GetComponent<TextMeshProUGUI>().text = "[T] Turn on Auto Mode";
            }
            else
            {
                autoModeText.GetComponent<TextMeshProUGUI>().text = "[T] Turn off Auto Mode";
            }
            playerBulletGenerator.GetComponent<PlayerBulletGenerator>().InvertMode();
        }
    }
}
