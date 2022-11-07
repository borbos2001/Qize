
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class TextRead : MonoBehaviour
{
    [SerializeField] private SettingsPlayer _settingsPlayer;
    private SpawnLetter _spawnLetter;
    private GameControl _gameControl;
    private string _fullText;
    private HashSet<string> _wordsForQize = new HashSet<string>();
    private List<string> _uniqueWords;

    private void Start()
    {
        _gameControl = GetComponent<GameControl>();
        _spawnLetter = GetComponent<SpawnLetter>();
        _fullText = Resources.Load("text1").ToString();
        ChangeTextToWords();
        RandomizeWord();
    }

    private void ChangeTextToWords()
    {
        _fullText = _fullText.ToUpper();
        string[] words = new Regex("\\b[\\w']+\\b").Matches(_fullText).Cast<Match>().Select(m => m.Value).ToArray();
        foreach (string word in words)
        {
            if(word.Length >= _settingsPlayer.Lenght)
            _wordsForQize.Add(word);
        }
        _uniqueWords = _wordsForQize.ToList<string>();
    }
    public void RandomizeWord()
    {
        int _rand = Random.Range(0, _uniqueWords.Count);
        string _selectedWord = _uniqueWords.ElementAt(_rand);
        _uniqueWords.RemoveAt(_rand);
        _spawnLetter.WordParsing(_selectedWord);
        _gameControl._guessedWord = _selectedWord;
    }
    
}
