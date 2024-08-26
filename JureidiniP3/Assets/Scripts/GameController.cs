using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    public GameObject endGameText;
    public float gameOver;

    // Start is called before the first frame update
    void Start()
    {
        bool gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) {
            endGameText.SetActive(true);
        }
    }
}
