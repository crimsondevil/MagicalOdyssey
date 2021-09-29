using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Health = 100
/// Attack = -20,-30
/// Heal = +10
/// Defence = -
/// Buff = if this is played then next played card multiplied by 2
/// </summary>

public class SpellCard : MonoBehaviour
{
    public enum cardType { attack, heal, defence, buff };
    public cardType currCardType = cardType.attack;

    public int atk_dmg = 20;
    public int heal = 10;
    
    public void PlayCard()
    {
        switch(currCardType)
        {
            case cardType.attack:
                Attack();
                break; 

            case cardType.defence:
                Defence();
                break;

            case cardType.heal:
                Heal();
                break;

            case cardType.buff:
                Buff();
                break;
        }
        CardManager.Instance.playerCard = this;

        CardTableManager.Instance.PlayerObj = gameObject;
        CardTableManager.Instance.placePlayerCard();

        CardManager.Instance.playEnemyCard();
    }

    void Attack()
    {
        
        if (CardManager.Instance.isDefence == false)
        {
            if (CardManager.Instance.isPlayerBuff == true)
                CardManager.Instance.takeDamage(atk_dmg * 2);
            else 
                CardManager.Instance.takeDamage(atk_dmg);
        }

        CardManager.Instance.isDefence = false;
        CardManager.Instance.isPlayerBuff = false;

    }

    void Heal()
    {
        if (CardManager.Instance.isPlayerBuff == true)
            CardManager.Instance.healPlayer(heal * 2);
        else
            CardManager.Instance.healPlayer(heal);

        CardManager.Instance.isPlayerBuff = false;
    }

    void Defence()
    {
        CardManager.Instance.isPlayerDefence = true;
    }

    void Buff()
    {
        CardManager.Instance.isPlayerBuff = true;
    }
}