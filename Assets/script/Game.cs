using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject close_door;
    public GameObject open_door;
    public GameObject close_safe;
    public GameObject open_safe;
    public GameObject close_bookshelf;
    public GameObject open_bookshelf;
    public GameObject close_refrigerator;
    public GameObject open_refrigerator;
    public GameObject close_window;
    public GameObject open_window;
    public GameObject on_TV;
    public GameObject off_TV;
    public GameObject Chime;
    public GameObject Hint_Chime;

    public GameObject key1;
    public GameObject potato;
    public GameObject soccerball;
    public GameObject baseball;
    public GameObject radio;
    public GameObject CD;
    public GameObject food1;
    public GameObject food2;
    public GameObject rabbit;
    public GameObject eat_Rabbit;
    public GameObject Cage;
    public GameObject controller;
    public GameObject escapepanel;

    public GameObject keypadpanel;
    public InputField keypad;
    public GameObject check_button;

    public GameObject off_panel1;
    public GameObject off_panel2;
    public GameObject off_panel3;
    public GameObject off_panel4;
    public GameObject off_hint;

    public GameObject itemgetpanel; // 表示するための全画面の透明な土台
    public GameObject itemget;

    public GameObject key1_get; // 鍵入手時表示する
    public GameObject potato_get;
    public GameObject eat_potato_get;
    public GameObject key2_get;
    public GameObject baseball_get;
    public GameObject food_get;
    public GameObject controller_get;
    public GameObject CD_get;
    public GameObject radio_get;

    public GameObject talkPanel;

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    void Start()
    {
        itemgetpanel.SetActive(false); // デフォルトで非アクティブに設定
        open_door.SetActive(false);
        open_safe.SetActive(false);
        open_bookshelf.SetActive(false);
        open_refrigerator.SetActive(false);
        on_TV.SetActive(false);
        Hint_Chime.SetActive(false);
        open_window.SetActive(false);
        eat_Rabbit.SetActive(false); 

        keypadpanel.SetActive(false);
        keypad.gameObject.SetActive(false);
        check_button.SetActive(false);
        escapepanel.SetActive(false);

        talkPanel.SetActive(false);
        off_panel1.SetActive(false);
        off_panel2.SetActive(false);
        off_panel3.SetActive(false);
        off_panel4.SetActive(false);

        key1_get.SetActive(false);
        potato_get.SetActive(false);
        eat_potato_get.SetActive(false);
        key2_get.SetActive(false);
        baseball_get.SetActive(false);
        food_get.SetActive(false);
        controller_get.SetActive(false);
        CD_get.SetActive(false);
        radio_get.SetActive(false);
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
        escapepanel.SetActive(true);
    }

    public void open_doortap()
    {
        SceneManager.LoadScene("endScene");
    }

    public void close_safetap()
    {
        if(!key1.activeInHierarchy)
        {
            close_safe.SetActive(false);
            open_safe.SetActive(true);
        }
    }

    public void close_bookshelftap()
    {
        if (!potato.activeInHierarchy) {
            close_bookshelf.SetActive(false);
            open_bookshelf.SetActive(true);
        }
    }

    public void close_refrigeritortap()
    {
        keypadpanel.SetActive(true);
        keypad.gameObject.SetActive(true);
        check_button.SetActive(true);
    }



    public void cagetap()
    {
        if (!food1.activeInHierarchy)
        {
            rabbit.SetActive(false);
            eat_Rabbit.SetActive(true);
            food2.SetActive(true);
        }
    }



    public void key1get()
    {
        itemgetpanel.SetActive(true);
        itemget.SetActive(true);
        key1_get.SetActive(true);
        key1.SetActive(false);
    }

    public void key1gettap()
    {
        if (key1_get.activeInHierarchy == true)
        {
            itemgetpanel.SetActive(false);
            itemget.SetActive(false);
            key1_get.SetActive(false);
        }
    }

    public void potatoget()
    {
        itemgetpanel.SetActive(true);
        itemget.SetActive(true);
        potato_get.SetActive(true);
        potato.SetActive(false);
    }

    public void potatogettap()
    {
        if (potato_get.activeInHierarchy == true)
        {
            itemgetpanel.SetActive(false);
            itemget.SetActive(false);
            potato_get.SetActive(false);
        }
      
    }

    public void eat_potatoget()
    {
        itemgetpanel.SetActive(true);
        itemget.SetActive(true);
        eat_potato_get.SetActive(true);
    }

    public void eat_potatogettap()
    {
        if (eat_potato_get.activeInHierarchy == true)
        {
            itemgetpanel.SetActive(false);
            itemget.SetActive(false);
            eat_potato_get.SetActive(false);
        }
    }

    public void key2get()
    {
        itemgetpanel.SetActive(true);
        itemget.SetActive(true);
        key2_get.SetActive(true);
    }

    public void key2gettap()
    {
        if (key2_get.activeInHierarchy == true)
        {
            itemgetpanel.SetActive(false);
            itemget.SetActive(false);
            key2_get.SetActive(false);
        }
    }

    public void baseballget()
    {
        itemgetpanel.SetActive(true);
        itemget.SetActive(true);
        baseball_get.SetActive(true);
        baseball.SetActive(false);
        close_window.SetActive(false);
        Chime.SetActive(false);
        open_window.SetActive(true);
        Hint_Chime.SetActive(true);
    }

    public void baseballgettap()
    {
        if (baseball_get.activeInHierarchy == true)
        {
            itemgetpanel.SetActive(false);
            itemget.SetActive(false);
            baseball_get.SetActive(false);
        }
    }

    public void foodget()
    {
        itemgetpanel.SetActive(true);
        itemget.SetActive(true);
        food_get.SetActive(true);
        food1.SetActive(false);
    }

    public void foodgettap()
    {
        if (food_get.activeInHierarchy == true)
        {
            itemgetpanel.SetActive(false);
            itemget.SetActive(false);
            food_get.SetActive(false);
        }
    }

    public void controllerget()
    {
        itemgetpanel.SetActive(true);
        itemget.SetActive(true);
        controller_get.SetActive(true);
        controller.SetActive(false);
    }

    public void controllergettap()
    {
        if (controller_get.activeInHierarchy == true)
        {
            itemgetpanel.SetActive(false);
            itemget.SetActive(false);
            controller_get.SetActive(false);
        }
    }
}
