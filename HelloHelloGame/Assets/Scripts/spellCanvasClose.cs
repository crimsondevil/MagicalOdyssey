using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spellCanvasClose : MonoBehaviour
{

    // Start is called before the first frame update

    public GameObject Panel;
    
    public void closePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }
}
