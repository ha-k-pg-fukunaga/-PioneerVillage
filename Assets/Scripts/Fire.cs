using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float speed = 2.0f * Time.deltaTime;
        //transform.Translate(speed, 0.0f, 0.0f);

        float speed = 700.0f * Time.deltaTime;
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);

        if (transform.position.x >= 10.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);            
        }
    }
}
