using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalbattlemanager : MonoBehaviour
{
    public GameObject movementRef;
    public GameObject cardsRef;

    public GameObject healthbar1Ref;
    public GameObject healthbar2Ref;

    public GameObject text1Ref;
    public GameObject text2Ref;

    public GameObject text11Ref;
    public GameObject text22Ref;

    public GameObject Player1Ref;
    public GameObject EnemyRef;
    public GameObject PlayerBeforeDuelRef;

    public GameObject level4dialogueRef;

    public GameObject beforeCam;
    public GameObject afterCam;

    public GameObject StandPlayer;
    public GameObject StandEnemy;

    private void Start()
    {
        //Player1Ref.SetActive(false);
        //EnemyRef.SetActive(true);
        //StandPlayer.SetActive(true);
        StandEnemy.SetActive(true);
        text1Ref.SetActive(false);
        text2Ref.SetActive(false);
        text11Ref.SetActive(false);
        text22Ref.SetActive(false);
        healthbar1Ref.SetActive(false);
        healthbar2Ref.SetActive(false);
        cardsRef.SetActive(false);
    }

    public void startDuelGame()
    {
        StandPlayer.SetActive(false);
        StandEnemy.SetActive(false);
        Player1Ref.SetActive(true);
        EnemyRef.SetActive(true);
        text1Ref.SetActive(false);
        text2Ref.SetActive(false);
        text11Ref.SetActive(true);
        text22Ref.SetActive(true);
        healthbar1Ref.SetActive(true);
        healthbar2Ref.SetActive(true);
        cardsRef.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        beforeCam.SetActive(false);
        PlayerBeforeDuelRef.SetActive(false);
        afterCam.SetActive(true);
        StandPlayer.SetActive(true);
        //Player1Ref.SetActive(true);
        //EnemyRef.SetActive(true);
        level4dialogueRef.SetActive(true);
        movementRef.SetActive(false);
    }

}
