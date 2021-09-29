using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell_canvas_manager : MonoBehaviour
{
    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Canvas3;
    public GameObject Canvas4;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void display_Canvas1()
    {
        Canvas1.SetActive(true);
    }

    void display_Canvas2()
    {
        Canvas2.SetActive(true);
    }

    void display_Canvas3()
    {
        Canvas3.SetActive(true);
    }

    void display_Canvas4()
    {
        Canvas4.SetActive(true);
    }
}
