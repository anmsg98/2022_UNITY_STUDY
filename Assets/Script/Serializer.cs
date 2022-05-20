using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;

public class Serializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var data = new Data()
        {
            someDictionary = new Dictionary<string, int>(),
            dataName = "전성희",
            age = 25,
            height = 1.7f,
            playerPosition = new Vector3(1, 2, 3),
            playerRotation = transform.rotation.eulerAngles
        };
        
        data.someDictionary.Add("hey", 101010);
        
        var jsonStr = JsonConvert.SerializeObject(data);

        using (var fileStream =
               new FileStream(Path.Combine(Application.persistentDataPath, "save.json"), FileMode.Create))
        {
            var jsonByte = Encoding.UTF8.GetBytes(jsonStr);
            fileStream.Write(jsonByte);
        }
        print(jsonStr);
    }
}
