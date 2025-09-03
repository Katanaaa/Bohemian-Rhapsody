using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical1");
        }

        rb.velocity = new Vector2(0, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
    }
}

