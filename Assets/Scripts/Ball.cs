using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;

    [SerializeField] private float moveSpeed = 1f;
    
    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.velocity = _rigidbody2D.velocity.normalized * moveSpeed; // top hareketi
    }
}
