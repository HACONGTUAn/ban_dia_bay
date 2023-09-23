using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMangager : MonoBehaviour
{
    public Text Score;

    public GameObject gameoverPanel;

    public void SetScoreText(string txt)
    {
        if (Score)
        {
            Score.text = txt;
        }
    }

    public void ShowGameoverPanel(bool isShow) {

        if (gameoverPanel)
        {
            gameoverPanel.SetActive(isShow);
        }
    
    }
    
}
