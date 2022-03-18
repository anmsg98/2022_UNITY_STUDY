using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ComplexType
{
    public string name;
    public int age;
    public float height;
}
public class Study : MonoBehaviour
{
    private const float AttackInterval = 3f;
    private float _attackIntervalTimer;
    
    public ComplexType studyName;
    
    void Start()
    {
        InvokeRepeating(methodName: "PrintText", time:9f, repeatRate:3f);
    }
    
    // void Update()
    // {
    //     _attackIntervalTimer += Time.deltaTime;
    //
    //     if (_attackIntervalTimer > AttackInterval)
    //     {
    //         PrintText();
    //         _attackIntervalTimer = 0f;
    //     }
    // }
    //
    // void PrintText()
    // {
    //     print("공격!");
    // }
    //
    // // 컴포넌트 활성화시 실행
    // private void OnEnable()
    // {
    //     print("컴포넌트가 활성화 되었습니다.");
    // }
    //
    // // 컴포넌트 비활성화시 실행
    // private void OnDisable()
    // {
    //     print("컴포넌트가 비활성화 되었습니다.");
    // }
    // // 개인 pc 주사율, 성능에 무관하게 동일한 interval로 실행
    // private void FixedUpdate()
    // {
    //     print("컴포넌트가 주기적으로 업데이트 됩니다.");
    // }
    //
    // // Update() 다음으로 실행
    // private void LateUpdate()
    // {
    //     print("업데이트 뒤에 실행 됩니다.");
    // }
}
