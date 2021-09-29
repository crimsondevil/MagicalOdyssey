using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sort_Score : MonoBehaviour
{
    public static Sort_Score instance;
    public Text yourHouseName;

    public List<GameObject> questionsRef;

    //public Button btn1;
    //public Button btn2;
    //public Button btn3;
    //public Button btn4;

    private int questionIndex;

    private int Gryffy;
    private int Huffpuff;
    private int Slythy;
    private int RavClawy;

    public GameObject preHouseRef;

    public GameObject CanvaquidditcjRef;

    void Start()
    {
        preHouseRef.SetActive(false);
        questionIndex = 0;
        //startQuiz();

        //on trigger enter mei daalna hai startQuiz()//
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddScoreGryffy()
    {
        Gryffy++;
        nextQuestion();
        //Debug.Log("Score of Gryfindor is " + Gryffy);
    }

    public void AddScoreHuffpuff()
    {
        Huffpuff++;
        nextQuestion();
    }

    public void AddScoreSlythy()
    {
        Slythy++;
        nextQuestion();
    }

    public void AddScoreRavClawy()
    {
        RavClawy++;
        nextQuestion();
    }

    void nextQuestion()
    {
        questionsRef[questionIndex].SetActive(false);
        questionIndex++;

        if (questionIndex <= (questionsRef.Count - 1))
        {
            questionsRef[questionIndex].SetActive(true);
        }

        else
        {
            preHouseRef.SetActive(true);
            yourHouseName.text = calc_score();
            Invoke("disableText", 5f);
        }
    }

    public void startQuiz()
    {
        clearAll();
        questionIndex = 0;
        questionsRef[0].SetActive(true);    
    }

    private void clearAll()
    {
        foreach (GameObject q in questionsRef)
        {
            q.SetActive(false);
        }

        Gryffy = 0;
        Huffpuff = 0;
        Slythy = 0;
        RavClawy = 0;
    }


    private string calc_score()
    {
        List<int> HighScore = new List<int> ();
        HighScore.Add(Gryffy);
        HighScore.Add(Slythy);
        HighScore.Add(Huffpuff);
        HighScore.Add(RavClawy);

        HighScore.Sort();

        int max = HighScore[HighScore.Count - 1];

        if (max == Gryffy)
        {
            return "Gryffindor";
        }

        else if (max == Slythy)
        {
            return "Slytherin";
        }

        else if (max == Huffpuff)
        {
            return "Hufflepuff";
        }

        else if (max == RavClawy)
        {
            return "Ravenclaw";
        }
        
        return "";
    }

    private void OnTriggerEnter(Collider other)
    {
        startQuiz();
    }

    private void disableText()
    {
        preHouseRef.SetActive(false);
        yourHouseName.text = " ";
        nextcanvasEnable();
    }

    private void nextcanvasEnable()
    {
        CanvaquidditcjRef.SetActive(true);
    }
}
