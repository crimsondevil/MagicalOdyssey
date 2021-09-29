using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public static CardManager Instance;

    public Text PlayerHealth;
    public Text EnemyHealth;

    public int playerhealth = 100;
    public int enemyhealth = 100;

    public SpellCard[] EnemyTurn1;
    public SpellCard[] EnemyTurn2;

    public int cardCounter = 0;
    public int turnCounter = 1;

    public bool isDefence = false;
    public bool isBuff = false;

    public bool isPlayerDefence = false;
    public bool isPlayerBuff = false;

    public SpellCard playerCard;

    public HealthBar healthBar1;
    public HealthBar healthBar2;

    public Animator PlayerAttackAnim;

    public GameObject Round1Ref;
    public GameObject Round2Ref;

    public GameObject EnemyHeal;
    public GameObject EnemyDef;

    public Animator EnemyAnimatorRef;


    public bool ifwin = true;

    private void Start()
    {
        PlayerHealth.text = playerhealth.ToString();
        EnemyHealth.text = enemyhealth.ToString();
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void playEnemyEffect(SpellCard.cardType type1)
    {
        switch (EnemyTurn1[cardCounter].currCardType)
        {
            case SpellCard.cardType.attack:
                PlayerAttackAnim.Play("AttackAnimation");
                break;

            case SpellCard.cardType.defence:
                PlayerAttackAnim.Play("DefenceAnimation");
                break;

            case SpellCard.cardType.heal:
               
                break;

            case SpellCard.cardType.buff:
                
                break;
        }
    }

    public void endTurn()
    {
        CardTableManager.Instance.ClearCard();

        if (playerhealth > 100)
        {
            playerhealth = 100;
        }

        if (enemyhealth > 100)
        {
            enemyhealth = 100;
        }

        if (playerhealth < 0)
        {
            playerhealth = 0;
        }

        if (enemyhealth < 0)
        {
            enemyhealth = 0;
        }

        PlayerHealth.text = playerhealth.ToString();
        EnemyHealth.text = enemyhealth.ToString();

        healthBar1.SetHealth(playerhealth);
        healthBar2.SetHealth(enemyhealth);

        isDefence = false;
        isPlayerDefence = false;
    }

    public void giveDamagePlayer(int damage)
    {
        if (!isPlayerDefence)
        {
            if (isBuff)
            {
                playerhealth = playerhealth - damage*2;
            }

            else
            {
                playerhealth = playerhealth - damage;
            }
        }

        isPlayerDefence = false;
        isBuff = false;

    }

    public void defendEnemy()
    {
        if (playerCard.currCardType == SpellCard.cardType.attack)
        {
            enemyhealth = enemyhealth + playerCard.atk_dmg;
        }

        else
            isDefence = true;
    }

    public void healEnemy()
    {
        if (isBuff)
        {
            enemyhealth = enemyhealth + 20;
        }

        enemyhealth =enemyhealth + 10;
        isBuff = false;
    }

    public void buffEnemy()
    {
        isBuff = true;
    }


    public void playEnemyCard()
    {
        switch (turnCounter)
        {
            case 1:

                switch (EnemyTurn1[cardCounter].currCardType)
                {
                    case SpellCard.cardType.attack:
                        giveDamagePlayer(EnemyTurn1[cardCounter].atk_dmg);
                        //PlayerAttackAnim.Play("AttackAnimation");
                        EnemyAnimatorRef.Play("NewSimpleAtk");
                        break;

                    case SpellCard.cardType.defence:
                        EnemyAnimatorRef.Play("Enemy_Final_Def");
                        EnemyDef.SetActive(true);
                        Invoke("EnemyDefenceOff", 3);
                        defendEnemy();
                        break;

                    case SpellCard.cardType.heal:
                        EnemyAnimatorRef.Play("Enemy_Final_Heal");
                        EnemyHeal.SetActive(true);
                        Invoke("EnemyHealOff", 2f);
                        healEnemy();
                        break;

                    case SpellCard.cardType.buff:
                        buffEnemy();
                        break;
                }
                CardTableManager.Instance.EnemyObj = EnemyTurn1[cardCounter].gameObject;
                CardTableManager.Instance.placeEnemyCard();


                cardCounter = cardCounter + 1;

                break;

            case 2:

                switch (EnemyTurn2[cardCounter].currCardType)
                {
                    case SpellCard.cardType.attack:
                        giveDamagePlayer(EnemyTurn2[cardCounter].atk_dmg);
                        EnemyAnimatorRef.Play("NewSimpleAtk");
                        break;

                    case SpellCard.cardType.defence:
                        EnemyAnimatorRef.Play("Enemy_Final_Def");
                        EnemyDef.SetActive(true);
                        Invoke("EnemyDefenceOff", 3);
                        defendEnemy();
                        break;

                    case SpellCard.cardType.heal:
                        EnemyAnimatorRef.Play("Enemy_Final_Heal");
                        EnemyHeal.SetActive(true);
                        Invoke("EnemyHealOff", 2f);
                        healEnemy();
                        break;

                    case SpellCard.cardType.buff:
                        buffEnemy();
                        break;
                }
                CardTableManager.Instance.EnemyObj = EnemyTurn2[cardCounter].gameObject;
                CardTableManager.Instance.placeEnemyCard();


                cardCounter = cardCounter + 1;

                break;
        }

        if (turnCounter == 1 && cardCounter >= 5)
        {
            turnCounter = 2;
            cardCounter = 0;

            Invoke("Round2PanelOn", 3f);
        }

        else if (turnCounter == 2 && cardCounter >= 5)
        {
            if (playerhealth < enemyhealth)
            {
                ifwin = false;
            }

            CardTableManager.Instance.endBattle(ifwin);
        }
        
        //Debug.LogError(cardCounter);
                
        Invoke("endTurn", 3);

    }

    public void takeDamage(int damage)
    {
        enemyhealth = enemyhealth - damage;
    }

    public void healPlayer(int heal)
    {
        playerhealth = playerhealth + heal;
    }

    public void Round1PanelOn()
    {
        Round1Ref.SetActive(true);
        
        Invoke("Round1PanelOff", 2);
    }

    public void Round1PanelOff()
    {
        Round1Ref.SetActive(false);
    }

    public void Round2PanelOn()
    {
        Round2Ref.SetActive(true);

        Invoke("Round2PanelOff", 2);
    }

    public void Round2PanelOff()
    {
        Round2Ref.SetActive(false);
    }

    public void EnemyHealOff()
    {
        EnemyHeal.SetActive(false);
    }

    public void EnemyDefenceOff()
    {
        EnemyDef.SetActive(false);
    }
}