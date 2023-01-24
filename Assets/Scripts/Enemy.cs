using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Score = 1;
    public int Cost = 2;

    public int HP = 5;
    float invincibleTimer;

    GameObject obj = null;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 600.0f * Time.deltaTime;
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);

        if (transform.position.x <= -6.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Defender")
        {
            Debug.Log("Hit E");
            this.GetComponent<Rigidbody2D>().velocity = new Vector2( 0, 0);
        }
        else if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("Hit P");

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

            invincibleTimer += Time.deltaTime;

            if (invincibleTimer > 2.0f)
            {
                HP -= 1;
            }
        }
        else if (collision.gameObject.tag == "Fire")
        {
            HP -= 1;
        }

        if (HP < 0)
        {
            Destroy(gameObject);

            if (obj != null)
            {
                obj.GetComponent<GameController>().AddScore(Score);
                obj.GetComponent<GameController>().AddCost(Cost);
            }
        }
    }
}
