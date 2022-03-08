using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text textScore;
    public GameObject gameoverpanel;

    public void setTextScore(string txt)
    {
        if (textScore)
        {
            textScore.text = txt;
        }
    }

    public void ShowGameOverPanel(bool isShow)
    {
        if (gameoverpanel)
        {
            gameoverpanel.SetActive(isShow);
        }
    }
}
