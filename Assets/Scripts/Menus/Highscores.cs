using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscores : MonoBehaviour
{

    private float lvl1;
    private float lvl2;
    private float lvl3;
    [SerializeField]private Text lvl1Text;
    [SerializeField]private Text lvl2Text;
    [SerializeField]private Text lvl3Text;

    void Start()
    {
        lvl1 = PlayerPrefs.GetFloat("Level1Highscore");
        lvl2 = PlayerPrefs.GetFloat("Level2Highscore");
        lvl3 = PlayerPrefs.GetFloat("Level3Highscore");

        lvl1Text.text = lvl1.ToString();
        lvl2Text.text = lvl2.ToString();
        lvl3Text.text = lvl3.ToString();
    }

}
