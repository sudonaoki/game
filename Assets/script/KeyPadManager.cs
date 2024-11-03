using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro���g�p����ꍇ
using System;

public class KeyPadManager : MonoBehaviour
{
    // InputField�܂���TMP_InputField�̑I��
    public TMP_InputField passwordField;
    public GameObject close_refrigerator;
    public GameObject open_refrigerator;

    // �ȉ��̃I�u�W�F�N�g��錾
    public GameObject keypadpanel;
    public TMP_InputField keypad;
    public GameObject check_button;

    private string correctPassword = "wind";

    public void checktap()
    {
        // ���͂��ꂽ�p�X���[�h���擾
        string inputPassword = passwordField.text;

        // �p�X���[�h�����������`�F�b�N
        if (inputPassword == correctPassword)
        {
            // �①�ɂ̊J��؂�ւ���
            keypadpanel.SetActive(false);
            keypad.gameObject.SetActive(false);
            check_button.SetActive(false);
            close_refrigerator.SetActive(false);
            open_refrigerator.SetActive(true);
        }
    }
}
