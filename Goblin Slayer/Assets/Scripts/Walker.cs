﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Walker : MonoBehaviour {

    public float velocity;

    public WalkingState walkingState { get; private set; }
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public enum WalkingState { STOP = 0, RIGHT = 1, LEFT = -1};
    public enum WalkDirection { RIGHT = WalkingState.RIGHT, LEFT = WalkingState.LEFT};
    /// <summary>
    /// Makes the gameObject move in the given direction
    /// </summary>
    /// <param name="state">The direction in wich the gameObject should move</param>
    public void Walk(WalkDirection direction)
    {
        walkingState = (WalkingState)direction;
        rb.velocity = new Vector2((float)direction, 0) * velocity;
    }
    public void Stop()
    {
        walkingState = WalkingState.STOP;
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
}