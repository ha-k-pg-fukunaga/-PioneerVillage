using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ClickedCharctor;
    public GameObject SelectCharctor;
    public GameObject GameController;
    public int Cost;
    private Vector3 mousePosition;

    public void CreateChar(Vector3 pos)
    {
        if (ClickedCharctor.name == "Fence" && Cost >= 1)
        {
            GameController.GetComponent<GameController>().AddCost(-1);

            Instantiate(ClickedCharctor, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity);
        }
        else if (ClickedCharctor.name == "Warrior" && Cost >= 1)
        {
            GameController.GetComponent<GameController>().AddCost(-1);

            Instantiate(ClickedCharctor, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity);
        }
        else if (ClickedCharctor.name == "Wizard" && Cost >= 2)
        {
            GameController.GetComponent<GameController>().AddCost(-2);

            Instantiate(ClickedCharctor, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity);
        }
        else
        {
            return;
        }
    }

    public void UpdateCost(int get_cost)
    {
        Cost = get_cost;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameController = GameObject.Find("GameController");
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
                    ClickedCharctor = hit2D.transform.gameObject;
                }
            }
            else if(ClickedCharctor != null)
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
