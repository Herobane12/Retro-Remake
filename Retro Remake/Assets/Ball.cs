using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D ball;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        float xVelocity = UnityEngine.Random.Range(-1.5f, 1.5f);
        float yVelocity = UnityEngine.Random.Range(-4f, 4f);

        ball.velocity = new Vector2(xVelocity, yVelocity).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
    }

}
