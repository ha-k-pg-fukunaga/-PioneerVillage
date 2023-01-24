using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiCost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCost(int cost)
    {
        Text text_obj = GetComponent<Text>();

        text_obj.text = "Cost:" + cost.ToString();
    }
}
