
using UnityEngine;


[CreateAssetMenu(fileName = "SettingsGame", menuName = "ScriptableObjects", order = 1)]
public class SettingsPlayer : ScriptableObject
{
    [SerializeField] private int _lives;
    [SerializeField] private int _lengthOfWords;
    public int MaxLivesPlayer
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
