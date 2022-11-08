
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject _placeForButtons;
    public string _guessedWord;
    private TextRead _textRead;
    private int i = 0;

    private void Start()
    {
        _textRead = gameObject.GetComponent<TextRead>();
    }
    public void WordGuessingTest()
    {
        Transform newresult;
        i++;
        if (i >= _guessedWord.Length)
        {
            _textRead.RandomizeWord();
            for (int i = 0; i < 26; i++)
            {
                newresult = _placeForButtons.transform.Find("BlockButton" + i);
                newresult.gameObject.SetActive(false);

            }
        }
        
    }
}
