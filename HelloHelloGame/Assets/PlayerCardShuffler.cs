using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardShuffler : MonoBehaviour
{

    int counter = 0;
    public GameObject turn1Player;
    public GameObject turn2Player;

    public void setGameObjectFalse(GameObject objRef)
    {
        counter = counter + 1;

        turnChecker();

    }

    void turnChecker()
    {
        if (counter > 4)
        {
            Invoke("nextturn", 3.5f);
        }
    }

    void nextturn()
    {
        turn1Player.SetActive(false);
        turn2Player.SetActive(true);
    }

}
