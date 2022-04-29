using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButtonUI : MonoBehaviour
{
    public ObjectPoolingManager poolingManager;
    
    public void Spawn(string objecstName)
    {
        var position = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
            );
        var rotation = new Vector3(
            Random.Range(-180f, 180f), 
            Random.Range(-180f, 180f),
            Random.Range(-180f, 180f)
        );
        poolingManager.Get(objecstName, position, Quaternion.identity);
    }
}
