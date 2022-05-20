using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class Data
{
    public Dictionary<string, int> someDictionary;
    public Queue<string> someQueue;
    
    public string dataName;
    public int age;
    public float height;
    public Vector3 playerPosition;
    
    [JsonIgnore]
    public Vector3 playerRotation;
}
