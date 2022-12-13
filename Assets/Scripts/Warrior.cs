using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    int HP = 4;
    float invincibleTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            invincibleTimer += Time.deltaTime;

            if (invincibleTimer > 2.0f)
            {
                HP -= 1;
            }

            if (HP < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
