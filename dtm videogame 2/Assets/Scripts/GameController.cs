using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI youWin;
    public bool isGameActive;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (score > 100f)
        {
            youWin.gameObject.SetActive(true);
            isGameActive = true;
        }

    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
        Debug.Log(score);
    }
}
