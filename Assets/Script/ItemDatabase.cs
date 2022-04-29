using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[CreateAssetMenu(order = 0, fileName = "Item Database", menuName = "Study/Item/create Item DB")]
public class ItemDatabase : ScriptableObject
{
    public ItemData[] itemDatas;
    
}

[Serializable]
public class ItemData
{
    public string itemName;
    public int itemLevel;
    public float itemDefaultDur;
    public Sprite itemThumbnail;
}

public class SwordData
{
    public string itemName;
    public int itemLevel;
    public float attackPower;
}

