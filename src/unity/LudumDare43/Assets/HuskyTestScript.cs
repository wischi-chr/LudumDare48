﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuskyTestScript : MonoBehaviour {
    public int mutliSpeed = 40;
    public Animator animator;
    public SpriteRenderer SpriteRenderer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var speed = Input.GetAxisRaw("Horizontal") * mutliSpeed;

        animator.SetFloat("Speed", Mathf.Abs(speed));


        if (speed < -0.01 && !SpriteRenderer.flipX)
        {
            SpriteRenderer.flipX = true;
        }
        else if (speed > 0.01 && SpriteRenderer.flipX)
        {
            SpriteRenderer.flipX = false;
        }
	}
}