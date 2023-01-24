using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailedText : MonoBehaviour
{
    [SerializeField]
    private Text failedText;

    public void UpdateFailed(int score)
    {
        failedText.text = "Game Over\n" + "Score:" + score.ToString();
    }
}
