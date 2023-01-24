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
    public GameObject UiClear;
    public GameObject UiFailed;

    int Score = 0;

    public void AddScore(int add_value)
    {
        Score += add_value;

        UiScore.GetComponent<UIScore>().UpdateScore(Score);
    }

    public void GetScore(int score)
    {
        score = Score;
    }

    public void Creared()
    {
        EnemyFactory.Stop();

        UiClear.GetComponentInChildren<ClearText>().UpdateClear(Score);

        UiClear.SetActive(true);

        currentStep = GameStep.Finish;
    }

    public void Failed()
    {
        EnemyFactory.Stop();

        GameObject.Find("Timer").GetComponent<Timer>().Stop();

        UiFailed.GetComponentInChildren<FailedText>().UpdateFailed(Score);

        UiFailed.SetActive(true);

        currentStep = GameStep.Finish;
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

    void UpdateFinishStep()
    {
        if(Input.GetMouseButtonDown(0) == true)
        {

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        AddScore(0);

        UiClear.SetActive(false);
        UiFailed.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentStep)
        {
            case GameStep.Start:
                UpdateStartStep();
                break;
            case GameStep.Finish:
                UpdateFinishStep();
                break;
        }
    }
}
