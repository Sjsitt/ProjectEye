using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MiniMenu : MonoBehaviour
{

    public static MiniMenu Instance;

    void Awake()
    {
        Instance = this;
    }

    public GameObject FigPos1;

    public GameObject fig1;

    public GameObject fig11;

    public GameObject fig2;

    public GameObject fig21;

    public GameObject fig3;

    public GameObject fig31;

    public GameObject fig4;

    public GameObject fig41;

    public GameObject fig5;

    public GameObject fig51;

    public GameObject fig6;

    public GameObject fig61;

    public GameObject fig7;

    public GameObject fig71;

    public GameObject FigPos2;

    public GameObject FigPos3;

    public GameObject FigPos4;

    public GameObject FigPos5;

    public GameObject FigPos6;

    public GameObject FigPos7;



    public bool FP1;
    public bool FP2;
    public bool FP3;
    public bool FP4;
    public bool FP5;
    public bool FP6;
    public bool FP7;


    private int counter = 1;

    private void Start()
    {
        Pos1();
    }
    void Update()
    {

/*        Checkfigure();*/

    }

    public void Pos1()
    {
        FigPos1.SetActive(true);

        fig1.transform.position = new Vector3(10, 0, 0);

        fig11.transform.position = new Vector3(-10, 0, 0);

        FP1 = true;

        FP2 = false;
        
        FP3 = false;

        FP4 = false;

        FP5 = false;

        FP6 = false;

    }
    public void Pos2()
    {
        FigPos2.SetActive(true);

        fig2.transform.position = new Vector3(10, 0, 0);

        fig21.transform.position = new Vector3(-10, 0, 0);

        FP1 = false;

        FP2 = true;

        FP3 = false;

        FP4 = false;

        FP5 = false;

        FP6 = false;

    }
    public void Pos3()
    {
        FigPos3.SetActive(true);

        fig3.transform.position = new Vector3(10, 0, 0);

        fig31.transform.position = new Vector3(-10, 0, 0);

        FP1 = false;

        FP2 = false;

        FP3 = true;

        FP4 = false;

        FP5 = false;

        FP6 = false;

    }
    public void Pos4()
    {
        FigPos4.SetActive(true);

        fig4.transform.position = new Vector3(10, 0, 0);

        fig41.transform.position = new Vector3(-10, 0, 0);

        FP1 = false;

        FP2 = false;

        FP3 = false;

        FP4 = true;

        FP5 = false;

        FP6 = false;

    }

    public void Pos5()
    {
        FigPos5.SetActive(true);

        fig5.transform.position = new Vector3(10, 0, 0);

        fig51.transform.position = new Vector3(-10, 0, 0);

        FP1 = false;

        FP2 = false;

        FP3 = false;

        FP4 = false;

        FP5 = true;

        FP6 = false;

    }

    public void Pos6()
    {
        FigPos6.SetActive(true);

        fig6.transform.position = new Vector3(10, 0, 0);

        fig61.transform.position = new Vector3(-10, 0, 0);

        FP1 = false;

        FP2 = false;

        FP3 = false;

        FP4 = false;

        FP5 = false;

        FP6 = true;

    }

    public void Pos7()
    {
        FigPos7.SetActive(true);

        fig7.transform.position = new Vector3(10, 0, 0);

        fig71.transform.position = new Vector3(-10, 0, 0);

        FP1 = false;

        FP2 = false;

        FP3 = false;

        FP4 = false;

        FP5 = false;

        FP6 = false;

        FP7 = true;

    }



    public void Checkfigure()
    {
        if (FP1 == true)
        {

            FP2 = false;
            FP3 = false;
            FP4 = false;
            FP5 = false;
            FP6 = false;
            FP7 = false;

        }
        if (FP2 == true)
        {
            FP1 = false;
            FP3 = false;
            FP4 = false;
            FP5 = false;
            FP6 = false;
            FP7 = false;


        }
        if (FP3 == true)
        {
            FP1 = false;
            FP2 = false;
            FP4 = false;
            FP5 = false;
            FP6 = false;
            FP7 = false;

        }
        if (FP4 == true)
        {
            FP1 = false;
            FP2 = false;
            FP3 = false;
            FP5 = false;
            FP6 = false;
            FP7 = false;

        }
        if (FP5 == true)
        {
            FP1 = false;
            FP2 = false;
            FP3 = false;
            FP4 = false;
            FP6 = false;
            FP7 = false;
        }
        if (FP6 == true)
        {
            FP1 = false;
            FP2 = false;
            FP3 = false;
            FP4 = false;
            FP5 = false;
            FP7 = false;
        }
        if (FP7 == true)
        {
            FP1 = false;
            FP2 = false;
            FP3 = false;
            FP4 = false;
            FP5 = false;
            FP6 = false;
        }
    }
    
    public void FigureChanger()
    {

        switch (counter)
        {
            case 1:
                Pos2();
                Debug.Log("Первый метод");
                FigPos1.SetActive(false);
                break;
            case 2:
                Pos3();
                Debug.Log("Второй метод");
                FigPos2.SetActive(false);
                break;
            case 3:
                Pos4();
                Debug.Log("Третий метод");
                FigPos3.SetActive(false);
                break;
            case 4:
                Pos5();
                Debug.Log("Четвертый метод");
                FigPos4.SetActive(false);
                break;
            case 5:
                Pos6();
                Debug.Log("Пятый метод");
                FigPos5.SetActive(false);
                break;
            case 6:
                Pos7();
                Debug.Log("Шестой метод");
                FigPos6.SetActive(false);
                break;
            case 7:
                Pos1();
                Debug.Log("Седьмой метод");
                FigPos7.SetActive(false);
                break;


        }
        counter += 1;
        if (counter > 7)
        {
            counter = 1;
        }
    }


}


