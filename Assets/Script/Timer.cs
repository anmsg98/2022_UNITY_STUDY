using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;

    private void Start()
    {
        StartCoroutine(Time());
    }

    private IEnumerator Time()
    {
        var elapsedTime = 0f;
        while (true)
        {
            yield return null;
            elapsedTime += UnityEngine.Time.deltaTime;
            timerText.text = elapsedTime.ToString();
        }
    }
    
}
