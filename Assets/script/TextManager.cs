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
    public TextMeshProUGUI NameText; // �ǉ�(���O��\������e�L�X�gUI)
    public TextMeshProUGUI LogText; // �ǉ�(�Z���t�E�n�̕���\������e�L�X�gUI)

    void Start()
    {
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
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // �}�E�X���{�^�����N���b�N���ꂽ��
        {
            if (i < csvData.Count) // �C���f�b�N�X���͈͓��ł��邩�m�F
            {
                NameText.text = csvData[i][0]; // �C���f�b�N�Xi��0�Ԗڂ̗v�f�𖼑O�e�L�X�gUI�ɕ\������
                LogText.text = csvData[i][1]; // �C���f�b�N�Xi��1�Ԗڂ̗v�f���Z���t�E�n�̕��e�L�X�gUI�ɕ\������
                i++; // �C���f�b�N�X���C���N�������g����
            }
            else
            {
                Debug.LogWarning("No more lines in CSV file.");
            }
        }
    }
}
