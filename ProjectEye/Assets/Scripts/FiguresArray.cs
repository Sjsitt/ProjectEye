using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FiguresArray : MonoBehaviour
{

    public GameObject[] figures;

    private int? RndIndex = null;

    System.Random rnd = new System.Random();

    public static FiguresArray Instance;

    void Awake()
    {
        Instance = this;
    }

    private void GetRandomIndex()
    {

        var test = Random.Range(0, figures.Length - 1);

        if (RndIndex == null)
        {
            RndIndex = test;
        }
        else
        {
            if (RndIndex != test)
            {
                RndIndex = test;
            }
            else
            {
                GetRandomIndex();
            }
        }

    }

    public GameObject GetRandomFigure()
    {

        GetRandomIndex();

        var coinposition = figures[RndIndex.Value];

        Debug.Log("Coin Index:" + RndIndex.Value);

        return coinposition;

    }
}
