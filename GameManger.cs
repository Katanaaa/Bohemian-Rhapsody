using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int P1;
    private int P2;

    public void Player1Scored()
    {
      P1!++;
        player1Text.GetComponent<TextMeshProUGUI>().text = P1.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        P2++;
        player2Text.GetComponent<TextMeshProUGUI>().text = P2.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<ball>().Reset();
       
    }
}