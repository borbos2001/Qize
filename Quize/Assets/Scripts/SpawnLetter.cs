using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpawnLetter : MonoBehaviour
{
    [SerializeField] private GameObject _letter;
    [SerializeField] private Sprite[] _spriteLetter;
    [SerializeField] private Transform _canvas;
    private List<Transform> _spawnedLetters;
    private string _alphabet = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ'";
    public void WordParsing(string _word)
    {
        for (int i = 0;i < _word.Length; i++ )
        {
            int _numLetter = _alphabet.IndexOf(_word[i]);
            Spawn(_numLetter, i);
        }
    }
    private void Spawn(int _numOfLetter,int _sequenceNumber)
    {
        GameObject _spawnLetter = (GameObject)Instantiate(_letter);
        _spawnLetter.transform.gameObject.GetComponent<Image>().sprite = _spriteLetter[_numOfLetter];
        _spawnLetter.transform.SetParent(_canvas.transform);
        _spawnLetter.transform.position = new Vector2(300+(100*_sequenceNumber), 600);
        _spawnedLetters.Add(_spawnLetter.transform);
        _spawnedLetters[_sequenceNumber].gameObject.GetComponent<InformationAboutLetter>()._indexLetter = _numOfLetter;
    }
    public List<Transform> LetterOnBoard
    {
        get
        {
            return _spawnedLetters;
        }
    }


}

