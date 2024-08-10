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
    int i = 0; // インデックスカウンター
    public TextMeshProUGUI NameText; // 追加(名前を表示するテキストUI)
    public TextMeshProUGUI LogText; // 追加(セリフ・地の文を表示するテキストUI)

    void Start()
    {
        csvFile = Resources.Load("csv/会話") as TextAsset; // "会話"という名前のテキストアセットをロードする
        StringReader reader = new StringReader(csvFile.text); // CSVファイルのテキストを読み込むリーダーを作成

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1行読み込む
            csvData.Add(line.Split(',')); // 読み込んだ行をカンマで分割してリストに追加する
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // マウス左ボタンがクリックされたら
        {
            NameText.text = csvData[i][0]; // インデックスiの0番目の要素を名前テキストUIに表示する
            LogText.text = csvData[i][1]; // インデックスiの1番目の要素をセリフ・地の文テキストUIに表示する

            if (i < csvData.Count - 1) // インデックスiがCSVデータの要素数未満の場合
            {
                i++; // インデックスをインクリメントする
            }
        }
    }
}