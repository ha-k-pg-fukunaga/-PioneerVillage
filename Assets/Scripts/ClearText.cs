using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearText : MonoBehaviour
{
    [SerializeField]
    private Text clearText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateClear(int score)
    {
        clearText.text = "Game Clear\n" + "Score:" + score.ToString();  
    }
}
