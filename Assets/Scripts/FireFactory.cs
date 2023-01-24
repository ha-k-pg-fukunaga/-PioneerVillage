using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFactory : MonoBehaviour
{
    public GameObject FirePrefab;

    private float coolTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("Hit F");
            coolTime -= Time.deltaTime;

            //Debug.Log(coolTime);
            if (coolTime < 0.0f)
            {
                if (FirePrefab != null)
                {
                    //Debug.Log("Fire");
                    Instantiate(FirePrefab, transform.position, Quaternion.identity);
                }
                coolTime = 6.0f;
            }
        }        
    }
}
