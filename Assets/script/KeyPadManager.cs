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
        // ���͂��ꂽ�p�X���[�h���擾
        string inputPassword = passwordField.text;

        // �p�X���[�h�����������`�F�b�N
        if (inputPassword == correctPassword)
        {
            // �①�ɂ̊J��؂�ւ���
            close_refrigerator.SetActive(false);
            open_refrigerator.SetActive(true);
        }
        
    }
}

