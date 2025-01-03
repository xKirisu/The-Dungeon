using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rbody;
    SpriteRenderer spriteRenderer;


    [SerializeField] float MovementSpeed = 10f;
    // Start is called before the first frame update
    virtual protected void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected void Movement(float axisX, float axisY)
    {
        // move object
        rbody.velocity = new Vector2(axisX, axisY).normalized * MovementSpeed;

        // flip sprite
        if (rbody.velocity.x < 0 && !spriteRenderer.flipX)
        {
            spriteRenderer.flipX = true;
        }
        if (rbody.velocity.x > 0 && spriteRenderer.flipX)
        {
            spriteRenderer.flipX = false;
        }
    }
}
