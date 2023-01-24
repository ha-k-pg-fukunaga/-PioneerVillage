using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearText : MonoBehaviour
{
    [SerializeField]
    private Text clearText;

    public void UpdateClear(int score)
    {
        clearText.text = "Game Clear\n" + "Score:" + score.ToString();  
    }
}
