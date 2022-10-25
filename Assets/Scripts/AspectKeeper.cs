using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class AspectKeeper : MonoBehaviour
{
    [SerializeField]
    private Camera targetCamera;

    [SerializeField]
    private Vector2 aspectVec;

    void Update()
    {
        var screenAspect = Screen.width / (float)Screen.height;
        var targetAspect = aspectVec.x / aspectVec.y;

        var magRact = targetAspect / screenAspect;

        var viewportRect = new Rect(0, 0, 1, 1);

        if (magRact < 1)
        {
            //‰¡•‚Ì•ÏX
            viewportRect.width = magRact;
            //’†‰›Šñ‚¹
            viewportRect.x = 0.5f - viewportRect.width * 0.5f;
        }
        else
        {
            //c•‚Ì•ÏX
            viewportRect.height = 1 / magRact;
            //’†‰›Šñ‚¹
            viewportRect.y = 0.5f - viewportRect.height * 0.5f;
        }

        targetCamera.rect = viewportRect;
    }
}
