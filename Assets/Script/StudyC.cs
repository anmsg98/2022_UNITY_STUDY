using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyC : MonoBehaviour
{
    // private void SayHello()
    // {
    //     print("안녕 안녕하세요");
    // }

    private void Start()
    {
        var b = transform.parent;
        transform.parent = null;
    }
}
