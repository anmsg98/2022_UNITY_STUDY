using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class WaitTime : MonoBehaviour
{
    void Start()
    {
        var thread = new Thread(Run);
        thread.Start();
    }

    private void Run()
    {
        print("야");
        Thread.Sleep(1000);
        print("꿀벌");
        
    }
}
