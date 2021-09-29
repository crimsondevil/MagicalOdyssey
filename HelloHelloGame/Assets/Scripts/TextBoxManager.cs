using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;
    public GameObject PlayButton;

    public Text theText;
    
    public TextAsset textFile;
    [Multiline(15)]
    public string[] textLines;

    public float delay = 0.02f;

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
        
        StartCoroutine(ShowText(textLines[currentLine]));
    }                       

    void Update()
    {
        //theText.text = textLines[currentLine];

        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended)
        {
            currentLine += 1;
            StartCoroutine(ShowText(textLines[currentLine]));

        }

        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    currentLine += 1;
        //    StartCoroutine(ShowText(textLines[currentLine]));
        //}

        if (currentLine > endAtLine)
        {
            textBox.SetActive(false);
            PlayButton.SetActive(true);
        }
    }

    private IEnumerator ShowText(string fullText)
    {
        Debug.Log(fullText);
        string currentText = "";
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            theText.text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
