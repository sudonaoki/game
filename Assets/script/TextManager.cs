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
    int i = 0; // �C���f�b�N�X�J�E���^�[
    public TextMeshProUGUI NameText; // �ǉ�(���O��\������e�L�X�gUI)
    public TextMeshProUGUI LogText; // �ǉ�(�Z���t�E�n�̕���\������e�L�X�gUI)

    void Start()
    {
        csvFile = Resources.Load("csv/��b") as TextAsset; // "��b"�Ƃ������O�̃e�L�X�g�A�Z�b�g�����[�h����
        StringReader reader = new StringReader(csvFile.text); // CSV�t�@�C���̃e�L�X�g��ǂݍ��ރ��[�_�[���쐬

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1�s�ǂݍ���
            csvData.Add(line.Split(',')); // �ǂݍ��񂾍s���J���}�ŕ������ă��X�g�ɒǉ�����
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // �}�E�X���{�^�����N���b�N���ꂽ��
        {
            NameText.text = csvData[i][0]; // �C���f�b�N�Xi��0�Ԗڂ̗v�f�𖼑O�e�L�X�gUI�ɕ\������
            LogText.text = csvData[i][1]; // �C���f�b�N�Xi��1�Ԗڂ̗v�f���Z���t�E�n�̕��e�L�X�gUI�ɕ\������

            if (i < csvData.Count - 1) // �C���f�b�N�Xi��CSV�f�[�^�̗v�f�������̏ꍇ
            {
                i++; // �C���f�b�N�X���C���N�������g����
            }
        }
    }
}