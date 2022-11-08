
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] private SettingsPlayer _settingsPlayer;
    [SerializeField] private GameObject _deathMessage;
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _scoreDeathText;
    [SerializeField] private GameObject _placeForButtons;
    [SerializeField] private Text _hpText;
    private int _score = 0;
    private int _hpNow;
    private SpawnLetter _spawnLetter;
    public string _guessedWord;
    private TextRead _textRead;
    private int i = 0;

    private void Start()
    {
        _hpNow = _settingsPlayer.MaxLivesPlayer;
        _spawnLetter = GetComponent<SpawnLetter>();
        _textRead = gameObject.GetComponent<TextRead>();
        _scoreDeathText.text = "Score: " + _score.ToString();
        _hpText.text = "Lives: " + _hpNow.ToString();

    }
    public void WordGuessingTest(int j)
    {
        Transform _buttonBlock;
        i = i + j;
  
        if (i >= _guessedWord.Length)
        {
            DeleteLetter();
            _spawnLetter.NullBoard();
            _textRead.RandomizeWord();
            _score += _hpNow;
            _scoreText.text = "Score: " + _score.ToString();
            for (int i = 0; i < 26; i++)
            {
                _buttonBlock = _placeForButtons.transform.Find("BlockButton" + i);
                _buttonBlock.gameObject.SetActive(false);
                _hpNow = _settingsPlayer.MaxLivesPlayer; 
                HpControl(0);
            }
            i = 0;
        }
        
    }
    private void DeleteLetter()
    {
        foreach (Transform letter in _spawnLetter.LetterOnBoard)
        {
            Destroy(letter.gameObject);
        }
    }

    public void HpControl(int hp)
    {
        _hpNow = _hpNow - hp;
        _hpText.text = "Lives: " + _hpNow.ToString();
        if (_hpNow <= 0)
        {
            _deathMessage.SetActive(true);
            _scoreDeathText.text = "Score: " + _score.ToString();
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
