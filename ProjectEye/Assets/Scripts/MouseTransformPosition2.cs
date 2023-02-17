using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class MouseTransformPosition2 : MonoBehaviour
{
    public Transform obj_1;

    public Transform obj_2;

    public GameObject csGameMenu;

    public bool WinGame;

    public static float dist;

    public Vector3 vertdist;

    private Vector3 pointScreen;

    private Vector3 offset;


    void OnMouseDown()
    {
        pointScreen = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
    }
    void OnMouseUp()
    {

        float numberz = (float)Math.Round((double)vertdist.z, 2);

        float numberx = (float)Math.Round((double)vertdist.x, 2);


        Debug.Log("По вертикали: " + numberz);

        Debug.Log("По горизонтали: " + numberx);



        if (Math.Abs(numberz) <= 2 && Math.Abs(numberx) <= 2)
        {

            Time.timeScale = 0f;

            csGameMenu.SetActive(true);

            ScoreXDegrees.DegreesXValue += numberx;

            ScoreZDegrees.DegreesValue += numberz;

            WinGame = true;

        }

        if (Math.Abs(numberz) < 1 && Math.Abs(numberx) < 1)
        {

            Score.ScoreValue += 1;

        }
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        
        transform.position= curPosition;

    }


    void Update()
    {

       /* MiniMenu.Instance.Checkfigure();*/

        vertdist = obj_1.position - obj_2.position;

        var heading = obj_1.position - obj_2.position;

        heading.y = 0;


        vertdist.y = 0;


        if(WinGame == true)
        {
          if(Input.GetKeyDown(KeyCode.Return))
            {
                RetToScene();
                Debug.Log("test");
            }
        }
    }


    public void RetToScene()
    {

        Time.timeScale = 1f;

        csGameMenu.SetActive(false);

        WinGame = false;                                                              

        ScoreXDegrees.DegreesXValue = 0;

        ScoreZDegrees.DegreesValue = 0;


        Figures2.Instance.FigureChanger();




    }

   


}
