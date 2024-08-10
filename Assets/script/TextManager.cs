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
    public TextMeshProUGUI NameText; // 追加(名前を表示するテキストUI)
    public TextMeshProUGUI LogText; // 追加(セリフ・地の文を表示するテキストUI)

    void Start()
    {
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
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // マウス左ボタンがクリックされたら
        {
            if (i < csvData.Count) // インデックスが範囲内であるか確認
            {
                NameText.text = csvData[i][0]; // インデックスiの0番目の要素を名前テキストUIに表示する
                LogText.text = csvData[i][1]; // インデックスiの1番目の要素をセリフ・地の文テキストUIに表示する
                i++; // インデックスをインクリメントする
            }
            else
            {
                Debug.LogWarning("No more lines in CSV file.");
            }
        }
    }
}
