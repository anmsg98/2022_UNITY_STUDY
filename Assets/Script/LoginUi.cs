using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginUi : MonoBehaviour
{
    public TMP_InputField idField;
    public TMP_InputField pwField;
    public Button loginButton;

    public GameObject loginPanel;
    public TMP_Text panelText;


    private void Start()
    {
        loginButton.onClick.AddListener(OnLoginButtonClicked);   
    }
    
    public void OnLoginButtonClicked()
    {
        if (idField.text == "anmsg98" && pwField.text == "wjstjd741568*")
        {
            loginPanel.SetActive(true);
            panelText.text = "로그인에 성공하였습니다.";
        }
        else
        {
            loginPanel.SetActive(true);
            panelText.text = "로그인에 실패하였습니다.";
        }
    }

}
