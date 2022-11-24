using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    private int _playerScore;
    public Text playerScore;
    public Text computerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScore.text = _playerScore.ToString();
        ResetRound();

    }
    public void ComputerScores()
    {
        _computerScore++;
        this.computerScore.text = _computerScore.ToString();
        ResetRound();

    }
    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

}
