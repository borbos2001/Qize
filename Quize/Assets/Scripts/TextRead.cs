using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextRead : MonoBehaviour
{
    private string _fullText;
    private void Start()
    {
        _fullText = Resources.Load("text1").ToString();
        ChangeToRead();
    }


    private void Update()
    {
        
    }
    private void ChangeToRead()
    {
        char[] _charToCorrect = { ' ', '*', '.', ',', '!', '?'};
        _fullText = _fullText.ToUpper();
        string[] q = _fullText.Split(_charToCorrect, StringSplitOptions.RemoveEmptyEntries);
        foreach (string i in q)
        {
            Debug.Log(q);
            
        }
    }
}
