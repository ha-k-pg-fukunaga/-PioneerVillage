using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFactory : MonoBehaviour
{
    public GameObject FirePrefab;

    float coolTime = 1.0f;

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
        Debug.Log("Hit F");
        coolTime -= Time.deltaTime;

        Debug.Log(coolTime);
        if (coolTime < 0.0f)
        {
            Debug.Log("Hit 2");
            if (FirePrefab == null)
            {
                Instantiate(FirePrefab, transform.position, Quaternion.identity);
            }
            Debug.Log("Hit 3");
            coolTime = 1.0f;
        }
    }
}
