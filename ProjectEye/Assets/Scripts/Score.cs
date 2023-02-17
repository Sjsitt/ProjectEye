using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreValue = 0;

    public Text ScoreText;


    private void Start()
    {
        ScoreText = GetComponent<Text>();

    }

    void Update()
    {
        ScoreText.text = "Очки: " + ScoreValue;
    }
}
