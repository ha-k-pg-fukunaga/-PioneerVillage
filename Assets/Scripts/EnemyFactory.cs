using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject EnemyPrefab;

    bool CanRun = false;

    public void  Resume()
    {
        CanRun = true;
    }

    public void Stop()
    {
        CanRun = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CreateEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreateEnemy()
    {
        Debug.Log(1);

        while (CanRun == false)
        {
            yield return null;
        }

        if (EnemyPrefab != null)
        {
            Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
        }

        int number = Random.Range(1, 5);

        switch(number)
        {
            case 1:
                Instantiate(EnemyPrefab, new Vector3(0.0f, 3.2f, 0.0f), Quaternion.identity);
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;
        }

        Debug.Log(2);
    }
}
