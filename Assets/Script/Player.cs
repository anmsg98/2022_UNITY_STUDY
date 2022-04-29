using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.coin++;
            var itemDatas = GameManager.Instance.itemDatabase.itemDatas;

            var itemsLowerThan3 =
                itemDatas
                    .Where(item => item.itemLevel < 3)
                    .Select(item => item.itemName);
                // from item in itemDatas
                // where item.itemLevel < 3
                // select item.itemName;
                
            foreach (var itemName in itemsLowerThan3)
            {
                print(itemName);
            }
        }
    }
}
