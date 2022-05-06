using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisons : MonoBehaviour
{
    public GameController gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager")
            .GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        // this section of code is called when monster and pizza collide
        // it destroys the object and adds a message to your log
        // it also runs the UpdateScore function and adds 5 to your score
        // parameters - monsters and pizza
        // return value - "it works", +5 to your score
        if (gameObject.tag == "Monsters" && other.gameObject.tag == "Pizza") 
        {
            Destroy(gameObject);
            Debug.Log("it works");
            gameManager.UpdateScore(5);
            
        }
    }
}
