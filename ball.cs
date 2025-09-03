using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector3 startPosition;

    // Start is called before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();   
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 1 ? 1 : -1;
        float y = Random.Range(0, 2) == 1 ? 1 : -1;

        rb.velocity = new Vector2(speed * x, speed * y);
    }
}