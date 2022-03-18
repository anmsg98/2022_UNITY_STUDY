using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    public abstract void Cry();

    private void Start()
    { 
        Cry();
    }
}
