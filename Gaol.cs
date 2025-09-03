using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaol : MonoBehaviour
{
    public bool isPlayer1Goal;

    // Event function
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            if (!isPlayer1Goal)
            {
                Debug.Log("Player 1 Scored...");
                GameObject.Find("GameManger").GetComponent<GameManger>().Player1Scored();
            }
            else
            {
                Debug.Log("Player 2 Scored...");
                GameObject.Find("GameManger").GetComponent<GameManger>().Player2Scored();
            }
        }
    }
}
