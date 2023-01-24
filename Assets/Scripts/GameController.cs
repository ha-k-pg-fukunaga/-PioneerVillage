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
    public ScoreViewer ScoreViewer;
    public CostViewer CostViewer;
    public GameObject UIClear;
    public GameObject UIFailed;
    public Player Player;

    private int score = 0;
    private int cost = 10;

    public void AddScore(int add_score)
    {
        score += add_score;

        ScoreViewer.DrawScore(score);
    }

    public void AddCost(int add_cost)
    {
        cost += add_cost;

        Player.UpdateCost(cost);
        CostViewer.DrawCost(cost);
    }

    public void Creared()
    {
        EnemyFactory.Stop();

        UIClear.GetComponentInChildren<ClearText>().UpdateClear(score);

        UIClear.SetActive(true);

        currentStep = GameStep.Finish;
    }

    public void Failed()
    {
        EnemyFactory.Stop();

        GameObject.Find("Timer").GetComponent<Timer>().Stop();

        UIFailed.GetComponentInChildren<FailedText>().UpdateFailed(score);

        UIFailed.SetActive(true);

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
        AddCost(0);

        UIClear.SetActive(false);
        UIFailed.SetActive(false);
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
