using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelselector : MonoBehaviour {
    public Button[] LevelButtons;

    void Start()
    {
        int LevelReached = PlayerPrefs.GetInt("LevelReached", 1);
        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i+1 > LevelReached)
                LevelButtons[i].interactable = false;
            else
                LevelButtons[i].interactable = true;
        }    
    }
}
