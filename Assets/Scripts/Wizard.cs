using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public int Hp = 2;
    private float invincibleTimer;

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
                Hp -= 1;

                invincibleTimer = 0;
            }

            if (Hp < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
