using UnityEngine;
using UnityEngine.UI;

public class ScoreZDegrees : MonoBehaviour
{

    public static float DegreesValue = 0;

    public Text DegreesText;


    void Start()
    {

        DegreesText = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {

        DegreesText.text = "По вертикали: " + DegreesValue;


    }
}
