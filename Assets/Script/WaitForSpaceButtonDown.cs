using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSpaceButtonDown : MonoBehaviour
{
    private bool _isSpaceButtonDown;
    
    void Start()
    {
        StartCoroutine(WaitForSpaceButton());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isSpaceButtonDown = true;
        }
    }

    private IEnumerator WaitForSpaceButton()
    {
        print("스페이스 버튼을 누르세요");
        yield return new WaitUntil(() => _isSpaceButtonDown == true);
        print("야호");
    }
}
