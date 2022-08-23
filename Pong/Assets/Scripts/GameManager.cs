using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;

    public Paddle computerPaddle;

    public Text playerScoreText;

    public Text computerScoreText;

    private int _playerScores;

    private int _computerScores;

    public void PlayerScores(){
        _playerScores++;
        this.playerScoreText.text = _playerScores.ToString();
        ResetRound();
    }

    public void ComputerScores(){
        _computerScores++;
        this.computerScoreText.text = _computerScores.ToString();
        ResetRound();
    }

    private void ResetRound(){
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetBall();
        this.ball.AddStartingForce();
    }
}
