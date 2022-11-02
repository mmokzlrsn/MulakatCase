using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Speed Of The Ball")]
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D ballRB;


    private void Awake()
    {
        ballRB = GetComponent<Rigidbody2D>();
    }

    private void Start()
    { 
        Throw();
    }

    private void Throw()
    {
        ballRB.velocity = new Vector2(moveSpeed * PositiveOrNegative(), moveSpeed * PositiveOrNegative());
    }

    public int PositiveOrNegative()
    {
        return Random.Range(0, 2) == 0 ? -1 : 1;
    }





}
