using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject close_door;
    public GameObject open_door;

    public GameObject key; // 鍵

    public GameObject itemget; // 表示するための全画面の透明な土台
    public GameObject key_get; // 鍵入手時表示する

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    void Start()
    {
        itemget.SetActive(false); // デフォルトで非アクティブに設定
        open_door.SetActive(false);
    }

    public void gotowall1()
    {
        wall1.SetActive(true);
        wall2.SetActive(false);
        wall3.SetActive(false);
        wall4.SetActive(false);
    }

    public void gotowall2()
    {
        wall1.SetActive(false);
        wall2.SetActive(true);
        wall3.SetActive(false);
        wall4.SetActive(false);
    }

    public void gotowall3()
    {
        wall1.SetActive(false);
        wall2.SetActive(false);
        wall3.SetActive(true);
        wall4.SetActive(false);
    }

    public void gotowall4()
    {
        wall1.SetActive(false);
        wall2.SetActive(false);
        wall3.SetActive(false);
        wall4.SetActive(true);
    }

    public void close_doortap()
    {
        if (!key.activeInHierarchy)
        {
            close_door.SetActive(false);
            open_door.SetActive(true);
        }
    }

    public void open_doortap()
    {
        SceneManager.LoadScene("endScene");
    }

    public void keyget()
    {
        itemget.SetActive(true);
        key_get.SetActive(true);
        key.SetActive(false);
    }

    public void itemgettap()
    {
        if (key_get.activeInHierarchy == true)
        {
            itemget.SetActive(false);
            key_get.SetActive(false);
        }
    }
}
