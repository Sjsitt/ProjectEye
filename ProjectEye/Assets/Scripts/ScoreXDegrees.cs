using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreXDegrees : MonoBehaviour
{

    public static float DegreesXValue = 0;

    public Text DegreesXText;

    void Start()
    {

        DegreesXText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        DegreesXText.text = "По горизонтали: " + DegreesXValue;

    }
}
