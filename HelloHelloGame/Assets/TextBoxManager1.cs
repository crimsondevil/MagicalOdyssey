using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager1 : MonoBehaviour
{
    public GameObject textBox;
    public GameObject PlayButton;

    public Text theText;

    public TextAsset textFile;
    [Multiline(15)]
    public string[] textLines;

    public int currentLine;
    public int endAtLine;


    void Start()
    {
        if (textFile != null)
        {
            textLines = (textFile.text.Split('x'));

        }

        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
    }

    void Update()
    {
        theText.text = textLines[currentLine];

        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended)
            //if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }

        if (currentLine > endAtLine)
        {
            textBox.SetActive(false);
            PlayButton.SetActive(true);
        }
    }
}