using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private SpawnLetter _spawnLetter;
    private GameControl _gameControl;
    private bool _hpChange = true;
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
            if (letter.gameObject.GetComponent<InformationAboutLetter>()._indexLetter == _indexLetter  )
            {
                Transform child = letter.transform.Find("Block");
                child.gameObject.SetActive(false);

                Transform _buttonBlock = _placeForButtons.transform.Find("BlockButton" + _indexLetter.ToString());
                _buttonBlock.gameObject.SetActive(true);

                _gameControl.WordGuessingTest(1);
                _hpChange = false;
            }
            else 
            if(letter.gameObject.GetComponent<InformationAboutLetter>()._indexLetter != _indexLetter )
            {
                Transform _buttonBlock = _placeForButtons.transform.Find("BlockButton" + _indexLetter.ToString());
                _buttonBlock.gameObject.SetActive(true);
                _gameControl.WordGuessingTest(0);

            }

        }
        if (_hpChange == true)
        {
            _gameControl.HpControl(1);
        }
        _hpChange = true;

    }
}
