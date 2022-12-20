using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore (int score)
    {
        Text text_obj = GetComponent<Text>();

        text_obj.text = "Score:" + score.ToString();
    }
}
