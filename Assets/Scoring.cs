using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public TextMesh highscore, score, balls;
    private int ballNum, scoreNum, highscoreNum;


    // Start is called before the first frame update
    void Start()
    {
        highscoreNum = 0;
        resetNumbers();
    }

    // Update is called once per frame
    void Update()
    {


    }

    public int getNumBalls()
    {
        return ballNum;
    }

    public void resetNumbers()
    {
        UpdateBalls(10);
        UpdateScore(0);
    }

    private void UpdateBalls(int amount)
    {
        ballNum = amount;
        balls.text = "Balls: " + ballNum;
    }

    public void DecrementBalls()
    {
        UpdateBalls(ballNum - 1);
    }

    public void IncreaseScore(int amount)
    {
        UpdateScore(scoreNum + amount);
    }

    private void UpdateScore(int amount)
    {
        scoreNum = amount;
        score.text = "Score: " + scoreNum;
        CheckHighScore();
    }

    private void CheckHighScore()
    {
        if (scoreNum > highscoreNum)
        {
            highscoreNum = scoreNum;
            highscore.text = "High Score: " + highscoreNum;
        }
       
    }

}
