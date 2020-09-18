using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private Text leftTextScore;
    [SerializeField] private Text rightTextScore;

    [SerializeField] private Goal leftGoal;
    [SerializeField] private Goal rightGoal;

    [SerializeField] private GameManager gameManager;


    private int leftScore = 0;

    private int rightScore = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddScore(Goal scoringSide)
    {
        if (scoringSide == leftGoal)
        {
            rightScore += 1;
            rightTextScore.CrossFadeColor(Color.red, 1f, false, false);
            rightTextScore.text = ScoreWithZero(rightScore);
            leftTextScore.CrossFadeColor(Color.white, 1f, true, false);
        }

        else
        {
            leftScore += 1;
            leftTextScore.CrossFadeColor(Color.blue, 1f, true, false);
            leftTextScore.text = ScoreWithZero(leftScore);
            rightTextScore.CrossFadeColor(Color.white, 1f, false, false);
        }

        if (rightScore == 11)
        {
            rightTextScore.CrossFadeColor(Color.yellow, 0.5f, true, false);
            this.HandleWin();
        }
        else if (leftScore == 11)
        {
            leftTextScore.CrossFadeColor(Color.yellow, 0.5f, true, false);
            this.HandleWin();
        }
    }

    private string ScoreWithZero(int score)
    {
        return score < 10 ? $"0{score}" : score.ToString();
    }

    private void HandleWin()
    {
        leftScore = 0;
        rightScore = 0;
        leftTextScore.text = "00";
        rightTextScore.text = "00";
    }
}
