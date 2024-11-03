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
    public GameObject fieldObject;

    public GameObject check_button;


    public GameObject off_hint;

    public GameObject key1_getpanel;
    public GameObject potato_getpanel;
    public GameObject potato_eat_getpanel;
    public GameObject key2_getpanel;
    public GameObject baseball_getpanel;
    public GameObject wind_getpanel;
    public GameObject food_getpanel;
    public GameObject controller_getpanel;
    public GameObject CD_getpanel;
    public GameObject radio_getpanel;

    public GameObject key1_itemget;
    public GameObject potato_itemget;
    public GameObject eat_potato_itemget;
    public GameObject key2_itemget;
    public GameObject baseball_itemget;
    public GameObject wind_itemget;
    public GameObject food_itemget;
    public GameObject controller_itemget;
    public GameObject CD_itemget;
    public GameObject radio_itemget;

    public GameObject key1_get;
    public GameObject potato_get;
    public GameObject eat_potato_get;
    public GameObject key2_get;
    public GameObject baseball_get;
    public GameObject wind_get;
    public GameObject food_get;
    public GameObject controller_get;
    public GameObject CD_get;
    public GameObject radio_get;

    public GameObject talkPanel;

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    public bool key2tap=false;

    void Start()
    {

        open_door.SetActive(false);
        open_safe.SetActive(false);
        open_bookshelf.SetActive(false);
        open_refrigerator.SetActive(false);
        on_TV.SetActive(false);
        Hint_Chime.SetActive(false);
        open_window.SetActive(false);
        eat_Rabbit.SetActive(false);

        off_hint.SetActive(false);

        keypadpanel.SetActive(false);
        check_button.SetActive(false);

        keypad = keypad.GetComponent<InputField>();
        fieldObject = GameObject.Find("keypad");
        fieldObject.SetActive(false);


        escapepanel.SetActive(false);

        talkPanel.SetActive(false);

        key1_getpanel.SetActive(false);
        potato_getpanel.SetActive(false);
        potato_eat_getpanel.SetActive(false);
        key2_getpanel.SetActive(false);
        baseball_getpanel.SetActive(false);
        wind_getpanel.SetActive(false);
        food_getpanel.SetActive(false);
        controller_getpanel.SetActive(false);
        CD_getpanel.SetActive(false);
        radio_getpanel.SetActive(false);

        key1_itemget.SetActive(false);
        potato_itemget.SetActive(false);
        eat_potato_itemget.SetActive(false);
        key2_itemget.SetActive(false);
        baseball_itemget.SetActive(false);
        wind_itemget.SetActive(false);
        food_itemget.SetActive(false);
        controller_itemget.SetActive(false);
        CD_itemget.SetActive(false);
        radio_itemget.SetActive(false);

        key1_get.SetActive(false);
        potato_get.SetActive(false);
        eat_potato_get.SetActive(false);
        key2_get.SetActive(false);
        baseball_get.SetActive(false);
        wind_get.SetActive(false);
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
        if (key2tap==true) {
            close_bookshelf.SetActive(false);
            open_bookshelf.SetActive(true);
        }
    }

    public void close_refrigeritortap()
    {
        keypadpanel.SetActive(true);
        fieldObject.SetActive(true);
        check_button.SetActive(true);

    }

    public void keypadtap()
    {
        keypadpanel.SetActive(true);
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

    public void TVtap()
    {
        if (off_TV.activeInHierarchy)
        {
            off_TV.SetActive(false);
            on_TV.SetActive(true);
        }
    }


    //
    public void key1get()
    {
        key1_getpanel.SetActive(true);
        key1_itemget.SetActive(true);

        key1_get.SetActive(true);

        key1.SetActive(false);
    }

    public void key1gettap()
    {
        if (key1_get.activeInHierarchy == true)
        {
            key1_getpanel.SetActive(false);
            key1_itemget.SetActive(false);
            key1_get.SetActive(false);
        }
    }

    public void potatoget()
    {
        potato_getpanel.SetActive(true);
        potato_itemget.SetActive(true);

        potato_get.SetActive(true);

        potato.SetActive(false);
    }

    public void potatogettap()
    {
        if (potato_get.activeInHierarchy == true)
        {
            potato_getpanel.SetActive(false);
            potato_itemget.SetActive(false);
            potato_get.SetActive(false);
            potato_eat_getpanel.SetActive(true);
            eat_potato_itemget.SetActive(true);
            eat_potato_get.SetActive(true);
        }
      
    }

    public void eat_potatoget()
    {
        potato_eat_getpanel.SetActive(true);
        eat_potato_itemget.SetActive(true);

        eat_potato_get.SetActive(true);
    }

    public void eat_potatogettap()
    {
        if (eat_potato_get.activeInHierarchy == true)
        {
            potato_eat_getpanel.SetActive(false);
            eat_potato_itemget.SetActive(false);
            eat_potato_get.SetActive(false);
            key2_getpanel.SetActive(true);
            key2_itemget.SetActive(true);
            key2_get.SetActive(true);
        }
    }

    public void key2get()
    {
        key2_getpanel.SetActive(true);
        key2_itemget.SetActive(true);

        key2_get.SetActive(true);

    }

    public void key2gettap()
    {
        if (key2_get.activeInHierarchy == true)
        {
            key2_getpanel.SetActive(false);
            key2_itemget.SetActive(false);
            key2_get.SetActive(false);
            key2tap = true;
        }
    }

    public void baseballget()
    {
        baseball_getpanel.SetActive(true);
        baseball_itemget.SetActive(true);

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
            baseball_getpanel.SetActive(false);
            baseball_itemget.SetActive(false);
            baseball_get.SetActive(false);
        }
    }

    public void windget()
    {
        wind_getpanel.SetActive(true);
        wind_itemget.SetActive(true);

        wind_get.SetActive(true);

    }

    public void windgettap()
    {
        if (wind_get.activeInHierarchy == true)
        {
            wind_getpanel.SetActive(false);
            wind_itemget.SetActive(false);
            wind_get.SetActive(false);
        }
    }

    public void foodget()
    {
        food_getpanel.SetActive(true);
        food_itemget.SetActive(true);

        food_get.SetActive(true);


        food1.SetActive(false);
    }

    public void foodgettap()
    {
        if (food_get.activeInHierarchy == true)
        {
            food_getpanel.SetActive(false);
            food_itemget.SetActive(false);
            food_get.SetActive(false);
        }
    }

    public void controllerget()
    {
        controller_getpanel.SetActive(true);
        controller_itemget.SetActive(true);

        controller_get.SetActive(true);

        controller.SetActive(false);
    }

    public void controllergettap()
    {

        if (controller_get.activeInHierarchy == true)
        {
            controller_getpanel.SetActive(false);
            controller_itemget.SetActive(false);
            controller_get.SetActive(false);
            wall1.SetActive(false);
            wall2.SetActive(true);
            wall3.SetActive(false);
            wall4.SetActive(false);
            off_hint.SetActive(true);
        }
    }

    public void CDget()
    {
        CD_getpanel.SetActive(true);
        CD_itemget.SetActive(true);

        CD_get.SetActive(true);
    }

    public void CDgettap()
    {
        if (CD_get.activeInHierarchy == true)
        {
            CD_getpanel.SetActive(false);
            CD_itemget.SetActive(false);
            CD_get.SetActive(false);
        }
    }
    public void radioget()
    {
        radio_getpanel.SetActive(true);
        radio_itemget.SetActive(true);

        radio_get.SetActive(true);


    }

    public void radiogettap()
    {
        if (radio_get.activeInHierarchy == true)
        {
            radio_getpanel.SetActive(false);
            radio_itemget.SetActive(false);
            radio_get.SetActive(false);
        }
    }
}
