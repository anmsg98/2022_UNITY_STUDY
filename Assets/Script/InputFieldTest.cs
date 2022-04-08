using UnityEngine;

public class InputFieldTest : MonoBehaviour
{
    public void OnValueChanged(string value)
    {
        print($"text : {value}");
    }
}
