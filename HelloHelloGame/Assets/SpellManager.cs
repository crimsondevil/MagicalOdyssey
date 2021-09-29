using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    private List<string> spellRef = new List<string>();

    private int spellIndex;

    public GameObject SpellButton;
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;

    public ThirdPersonMovement TPController;

    void Start()
    {
        spellIndex = 0;

        spellRef.Add("Spell1");
        spellRef.Add("Spell2");
        spellRef.Add("Spell3");
        //spellRef.Add("Spell4");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        nextSpell();
    }

    void nextSpell()
    {
        if (spellIndex <= (spellRef.Count - 1))
        {
            Debug.Log(spellRef[spellIndex]);
        }

        spellIndex++;
    }

    public void useSpell()
    {
        Debug.Log(spellIndex);
        TPController.ActivateSpell(spellIndex);

        Invoke("ObstacleOff", 3f);
    }

    private void ObstacleOff()
    {
        switch (spellIndex)
        {
            case 1:
                Obstacle1.SetActive(false);
                break;
            case 2:
                Obstacle2.SetActive(false);
                break;
            case 3:
                Obstacle3.SetActive(false);
                break;
        }
    }
}
