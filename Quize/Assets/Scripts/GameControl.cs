using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public string _guessedWord;
    private TextRead _textRead;
    private int i = 0;

    private void Start()
    {
        _textRead = gameObject.GetComponent<TextRead>();
    }
    public void WordGuessingTest()
    {
        i++;
        if (i >= _guessedWord.Length)
        {
            _textRead.RandomizeWord();
        }
        
    }
}
