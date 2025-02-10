using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    double num = 0;
    void Start() {
        score = 0;
        scoreText.text = "Score: " + score; }

    // Update is called once per frame
    void Update()
    {
        num += 0.1;
        if(num > 1){
            score += 1;
            scoreText.text = "Score: " + score;
            num = 0;
        }
    }
}
