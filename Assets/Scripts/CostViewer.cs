using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostViewer : MonoBehaviour
{
    [SerializeField]
    private Text text;

    public void DrawCost(int cost)
    { 
        text.text = "Cost:" + cost.ToString();
    }
}
