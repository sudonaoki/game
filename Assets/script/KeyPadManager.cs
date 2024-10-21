using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassManager : MonoBehaviour
{

    public InputField passwordField;
    public GameObject close_refrigerator; 
    public GameObject open_refrigerator;  

    private string correctPassword = "wind";

    public void checktap()
    {
        // 入力されたパスワードを取得
        string inputPassword = passwordField.text;

        // パスワードが正しいかチェック
        if (inputPassword == correctPassword)
        {
            // 冷蔵庫の開閉を切り替える
            close_refrigerator.SetActive(false);
            open_refrigerator.SetActive(true);
        }
        
    }
}

