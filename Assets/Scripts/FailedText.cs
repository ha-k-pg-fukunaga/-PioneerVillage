using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailedText : MonoBehaviour
{
    [SerializeField]
    private Text failedText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateFailed(int score)
    {
        failedText.text = "Game Over\n" + "Score:" + score.ToString();
    }
}
