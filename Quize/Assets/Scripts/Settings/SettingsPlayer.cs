using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SettingsGame", menuName = "ScriptableObjects", order = 1)]
public class SettingsPlayer : ScriptableObject
{
    [SerializeField] private int _lives;
    [SerializeField] private int _lengthOfWords;
    public int LivesPlayer
    {
        get
        {
            return _lives;
        }
    }
    public int Lenght
    {
        get
        {
            return _lengthOfWords;
        }
    }

}
