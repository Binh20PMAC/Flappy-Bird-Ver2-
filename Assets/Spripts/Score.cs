using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TMP_Text ScoreText;

    public static Score instance;

    float score;
    float temp;

    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        score = 0;
        temp = 0;
    }


    public void ScoreUp()
    {
        temp++;
        if (temp == 80)
        {
            temp /= 80;
            score++;
        }




        ScoreText.text = score.ToString();
    }

}
