using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private SpawnLetter _spawnLetter;
    private GameControl _gameControl;
    [SerializeField] private GameObject _placeForButtons;
    private void Start()
    {
        _gameControl = gameObject.GetComponent<GameControl>();
        _spawnLetter = GetComponent<SpawnLetter>();
    }
    public void PressButton(int _indexLetter)
    {
        foreach (Transform letter in _spawnLetter.LetterOnBoard)
        {
            if (letter.gameObject.GetComponent<InformationAboutLetter>()._indexLetter == _indexLetter)
            {
                Transform child = letter.transform.Find("Block");
                child.gameObject.SetActive(false);
                _gameControl.WordGuessingTest();
                Transform newresult = _placeForButtons.transform.Find("BlockButton" + _indexLetter.ToString());
                newresult.gameObject.SetActive(true);

            }
            else
            {
                Transform newresult = _placeForButtons.transform.Find("BlockButton" + _indexLetter.ToString());
                newresult.gameObject.SetActive(true);
            }
        }

    }
}
