using UnityEngine;
using UnityEngine.UI;

public class PassManager : MonoBehaviour
{
    public GameObject close_door;
    public GameObject open_door;
    public Text displayText; // ���͂���������\������e�L�X�g
    private string input = ""; // ���݂̓��͓��e

    public void Numbertap(string number)
    {
        // ������ǉ�
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
        // �������p�X���[�h���ǂ����𔻒肷��
        if (input == "1114") 
        {
            close_door.SetActive(false);
            open_door.SetActive(true);
        }
        
        // ���͂��N���A����
        input = "";
        UpdateDisplay();
    }
}
