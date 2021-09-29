using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketBallScore : MonoBehaviour
{
    public int Score = 0;

    public Text scoreRef;
    public AudioSource GoalScored;

    void Start()
    {
        scoreRef.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GoalScored.volume = Random.Range(0.9f, 1f);
        GoalScored.pitch = Random.Range(0.9f, 1.1f);
        GoalScored.Play();

        Score = Score + 100;
        scoreRef.text = Score.ToString();
    }
}
