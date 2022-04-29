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
            
            // Any
            // if (itemDatas.Any(item => item.itemLevel > 20))
            // {
            //     print("헉 레벨 20이 넘는 아이템이 있다?!");
            // }

            // FirstOrDefault
            // var sword1 = itemDatas.FirstOrDefault(item => item.itemName == "Sword1");
            // if (sword1 != null)  
            //     print($"{sword1.itemName}: Lv.{sword1.itemLevel}");
            // else
            // {
            //     print("그런건 없다 게이야 ㅋㅋ");
            // }

            // OrderBy
            // var itemDatasOrderedByLevel =
            //     itemDatas.OrderBy(item => item.itemLevel);
            // foreach (var itemData in itemDatasOrderedByLevel)
            //     print(itemData.itemName);
            
            // Aggregate
            // var itemNames = itemDatas
            //     .Select(item => item.itemName)
            //     .Aggregate((before, after) => before + ", " + after);
            //
            // print(itemNames);
            
            // 선택
            var swordDatas = itemDatas
                .Where(item => item.itemName.Contains("Sword"))
                .Select(item => new SwordData
                {
                    itemName = item.itemName,
                    itemLevel = item.itemLevel,
                    attackPower = 10 * item.itemLevel
                });
            foreach (var swordData in swordDatas)
            {
                print($"{swordData.itemName}'s Power: {swordData.attackPower}");
            }
        }
    }
}
