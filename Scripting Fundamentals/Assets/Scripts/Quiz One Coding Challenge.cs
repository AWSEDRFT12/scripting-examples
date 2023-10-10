using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    // Declaring Variables 
    // Public Member/Gobal Variable
    
    public int Score = 0;
    public string PlayerName = "Anthony";
    public int Health = 100;

    // Private Member/Gobal Varible 
    

    // Start is called before the first frame update
    void Start()
    {
        IncreasingScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method Increase score 
    private void IncreasingScore()
    {
        Score = Score + 10;
    }
    
    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth()
    {
        Health = Health - 20;
    }
}
