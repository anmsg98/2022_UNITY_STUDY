using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class actionmap : MonoBehaviour
{
    private TMP_Text _text;
    public PlayerInput playerInput;
    
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
