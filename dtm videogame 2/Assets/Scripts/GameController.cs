using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameController gameManager;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI youWin;
    public TextMeshProUGUI youLose;
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
        if (transform.position.y < -5)
        {
            isGameActive = false;
            youLose.gameObject.SetActive(true);
            Application.Quit();
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
        Debug.Log(score);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        // this section of code is called when monster and pizza collide
        // it destroys the object and adds a message to your log
        // it also runs the UpdateScore function and adds 5 to your score
        // parameters - monsters and pizza
        // return value - "it works", +5 to your score
        if (gameObject.tag == "Monsters" && other.gameObject.tag == "Pizza" && isGameActive == true)
        {
            Destroy(gameObject);
            Debug.Log("it works");
            gameManager.UpdateScore(5);
        }
    }
}
