using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject EnemyPrefab;

    bool CanRun = false;
    float coolTime = 10.0f;

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
        //Debug.Log(1);

        while (CanRun == false)
        {
            yield return null;
        }

        if (EnemyPrefab != null)
        {
            //Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
        }

        while(CanRun ==  true)
        {
            int number = Random.Range(1, 6);

            switch (number)
            {
                case 1:
                    Instantiate(EnemyPrefab, new Vector3(9.0f, 2.62f, 0.0f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(EnemyPrefab, new Vector3(9.0f, 1.48f, 0.0f), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(EnemyPrefab, new Vector3(9.0f, 0.34f, 0.0f), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(EnemyPrefab, new Vector3(9.0f, -0.84f, 0.0f), Quaternion.identity);
                    break;
                default:
                    Instantiate(EnemyPrefab, new Vector3(9.0f, -1.98f, 0.0f), Quaternion.identity);
                    break;
            }

            coolTime -= 0.5f;
            if (coolTime < 3.0f)
            {
                coolTime = 3.0f;
            }
            yield return new WaitForSeconds(coolTime);
        }
    }
}
