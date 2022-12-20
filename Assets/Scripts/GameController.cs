using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    enum GameStep
    {
        Start,
        Main,
        Finish,
    }

    float timer = 0.0f;
    GameStep currentStep = GameStep.Start;
    public EnemyFactory EnemyFactory;
    public GameObject UiScore;

    int Score = 0;

    public void AddScore(int add_value)
    {
        Score += add_value;

        UiScore.GetComponent<UIScore>().UpdateScore(Score);
    }

    void UpdateStartStep()
    {
        timer += Time.deltaTime;

        if (timer >= 2.0f)
        {
            EnemyFactory.Resume();

            timer = 0.0f;

            currentStep = GameStep.Main;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentStep)
        {
            case GameStep.Start:
                UpdateStartStep();
                break;
        }
    }
}
