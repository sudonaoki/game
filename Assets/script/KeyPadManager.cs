using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshProを使用する場合
using System;

public class KeyPadManager : MonoBehaviour
{
    // InputFieldまたはTMP_InputFieldの選択
    public TMP_InputField passwordField;
    public GameObject close_refrigerator;
    public GameObject open_refrigerator;

    // 以下のオブジェクトを宣言
    public GameObject keypadpanel;
    public TMP_InputField keypad;
    public GameObject check_button;

    private string correctPassword = "wind";

    public void checktap()
    {
        // 入力されたパスワードを取得
        string inputPassword = passwordField.text;

        // パスワードが正しいかチェック
        if (inputPassword == correctPassword)
        {
            // 冷蔵庫の開閉を切り替える
            keypadpanel.SetActive(false);
            keypad.gameObject.SetActive(false);
            check_button.SetActive(false);
            close_refrigerator.SetActive(false);
            open_refrigerator.SetActive(true);
        }
    }
}
