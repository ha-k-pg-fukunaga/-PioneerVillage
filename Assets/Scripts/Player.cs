using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] charctors;
    public GameObject clickedCharctor;
    public GameObject selectCharctor;
    public GameObject gameController;
    private int score;

    public void CreateChar(Transform t)
    {
        if (clickedCharctor.name == "warrior" && score > 1)
        {
            gameController.GetComponent<GameController>().AddScore(-1);

            selectCharctor = Instantiate(clickedCharctor, t);
        }
        else if (clickedCharctor.name == "wizard" && score > 2)
        {
            gameController.GetComponent<GameController>().AddScore(-2);

            selectCharctor = Instantiate(clickedCharctor, t);
        }
        else
        {
            return;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController");

        gameController.GetComponent<GameController>().GetScore(score);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedCharctor = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2D)
            {
                clickedCharctor = hit2D.transform.gameObject;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            CreateChar(null);
        }
    }
}
