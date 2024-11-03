using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private TextAsset csvFile; // CSV�t�@�C���̃e�L�X�g�A�Z�b�g
    private List<string[]> csvData = new List<string[]>(); // CSV�f�[�^�̃��X�g
    private int i = 0; // �C���f�b�N�X�J�E���^�[
    public TextMeshProUGUI NameText; // ���O��\������e�L�X�gUI
    public TextMeshProUGUI LogText; // �Z���t�E�n�̕���\������e�L�X�gUI
    public Button nextButton; // �{�^���ɂ��i�s�p

    void Start()
    {
        // ������ԂŃe�L�X�gUI���N���A
        NameText.text = "";
        LogText.text = "";

        // CSV�t�@�C���̓ǂݍ���
        csvFile = Resources.Load("csv/��b") as TextAsset;
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
                csvData.Add(line.Split(',')); // �ǂݍ��񂾍s���J���}�ŕ������ă��X�g�ɒǉ�����
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
            // CSV�s��2�ȏ�̗v�f�����邩�m�F
            if (csvData[i].Length >= 2)
            {
                NameText.text = csvData[i][0]; // ���O��\��
                LogText.text = csvData[i][1]; // �Z���t�E�n�̕���\��
            }
            else
            {
                Debug.LogWarning("Invalid line format in CSV at index " + i);
            }
            i++; // �C���f�b�N�X���C���N�������g
        }
        else
        {
            // �Ō�܂ŕ\��������e�L�X�gUI���N���A
            NameText.text = "";
            LogText.text = "";
            Debug.LogWarning("No more lines in CSV file.");
        }
    }
}
