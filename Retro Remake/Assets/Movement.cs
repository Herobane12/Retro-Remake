using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D;
    public float speed = 6;

    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            _rb.velocity = Vector2.left * speed;
        }

        if (Input.GetKey(right))
        {
            _rb.velocity = Vector2.right * speed;
        }

    }
}
