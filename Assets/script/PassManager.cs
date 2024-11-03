using UnityEngine;
using UnityEngine.UI;

public class PassManager : MonoBehaviour
{
    public GameObject close_door;
    public GameObject open_door;
    public Text displayText; // 入力した数字を表示するテキスト
    private string input = ""; // 現在の入力内容

    public void Numbertap(string number)
    {
        // 数字を追加
        input += number;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displayText.text = input;
    }

    public void Cleartap()
    {
        input = "";
        UpdateDisplay();
    }

    public void Entertap()
    {
        // 正しいパスワードかどうかを判定する
        if (input == "1114") 
        {
            close_door.SetActive(false);
            open_door.SetActive(true);
        }
        
        // 入力をクリアする
        input = "";
        UpdateDisplay();
    }
}
