using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField]
    private Text text;

    public void DrawScore (int score)
    {
        text.text = "Score:" + score.ToString();
    }
}
