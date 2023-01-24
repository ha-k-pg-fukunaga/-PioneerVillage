using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public int Hp = 4;
    private float invincibleTimer = 0.0f;

    void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("Hit E");
        if (collision.gameObject.tag == "Enemy")
        {
            invincibleTimer += Time.deltaTime;

            if (invincibleTimer > 1.0f)
            {
                Hp -= 1;

                invincibleTimer = 0.0f;
            }

            if (Hp < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
