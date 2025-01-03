using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    // Start is called before the first frame update
    override protected void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(
            Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")
        );
    }
}
