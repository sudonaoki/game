using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private TextAsset csvFile; // CSVファイルのテキストアセット
    private List<string[]> csvData = new List<string[]>(); // CSVデータのリスト
    private int i = 0; // インデックスカウンター
    public TextMeshProUGUI NameText; // 名前を表示するテキストUI
    public TextMeshProUGUI LogText; // セリフ・地の文を表示するテキストUI
    public Button nextButton; // ボタンによる進行用

    void Start()
    {
        // 初期状態でテキストUIをクリア
        NameText.text = "";
        LogText.text = "";

        // CSVファイルの読み込み
        csvFile = Resources.Load("csv/会話") as TextAsset;
        if (csvFile == null)
        {
            Debug.LogError("CSV file not found!");
            return;
        }

        using (StringReader reader = new StringReader(csvFile.text))
        {
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                csvData.Add(line.Split(',')); // 読み込んだ行をカンマで分割してリストに追加する
            }
        }

        if (nextButton != null)
        {
            nextButton.onClick.AddListener(DisplayNextLine);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisplayNextLine();
        }
    }

    void DisplayNextLine()
    {
        if (i < csvData.Count)
        {
            // CSV行に2つ以上の要素があるか確認
            if (csvData[i].Length >= 2)
            {
                NameText.text = csvData[i][0]; // 名前を表示
                LogText.text = csvData[i][1]; // セリフ・地の文を表示
            }
            else
            {
                Debug.LogWarning("Invalid line format in CSV at index " + i);
            }
            i++; // インデックスをインクリメント
        }
        else
        {
            // 最後まで表示したらテキストUIをクリア
            NameText.text = "";
            LogText.text = "";
            Debug.LogWarning("No more lines in CSV file.");
        }
    }
}
