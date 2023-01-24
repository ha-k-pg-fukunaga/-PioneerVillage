using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] charctors;
    public GameObject clickedCharctor;
    public GameObject selectCharctor;
    public GameObject gameController;
    public int cost;
    private Vector3 mousePosition;
    private Vector3 selectPosition;

    public void CreateChar(Vector3 pos)
    {
        if (clickedCharctor.name == "Fence" && cost >= 1)
        {
            gameController.GetComponent<GameController>().AddCost(-1);

            Instantiate(clickedCharctor, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity);
        }
        else if (clickedCharctor.name == "warrior" && cost >= 1)
        {
            gameController.GetComponent<GameController>().AddCost(-1);

            Instantiate(clickedCharctor, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity);
        }
        else if (clickedCharctor.name == "wizard" && cost >= 2)
        {
            gameController.GetComponent<GameController>().AddCost(-2);

            Instantiate(clickedCharctor, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity);
        }
        else
        {
            return;
        }
    }

    public void UpdateCost(int get_cost)
    {
        cost = get_cost;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2D.transform.gameObject.tag == "Player" || hit2D.transform.gameObject.tag == "Defender")
            {                
                if (hit2D)
                {
                    clickedCharctor = hit2D.transform.gameObject;
                }
            }
            else if(clickedCharctor != null)
            {
                mousePosition = Input.mousePosition;

                mousePosition.z = 10.0f;

                CreateChar(mousePosition);
            }
            else
            {
                return;
            }
        }
    }
}
