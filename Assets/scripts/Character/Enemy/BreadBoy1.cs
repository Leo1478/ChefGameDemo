﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadBoy1 : BasicPathing
{
    // Start is called before the first frame update
    void Start()
    {
        startX = 25;
        endX = 35;
        direction = "right";
        moveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        moveSideToSide();
    }
}
