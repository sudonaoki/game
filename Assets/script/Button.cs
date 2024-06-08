using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

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
}
