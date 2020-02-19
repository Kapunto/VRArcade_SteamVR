using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pong_GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;

    public GameObject scoreGame;
    public GameObject theBall;
    PongBallController pongBall;

    private void Start()
    {
        pongBall = theBall.GetComponent<PongBallController>();
    }

    public void UpdateScore()
    {
        scoreGame.transform.Find("Computer").GetChild(1).GetComponent<TextMeshPro>().text = PlayerScore2.ToString();
        scoreGame.transform.Find("Player").GetChild(1).GetComponent<TextMeshPro>().text = PlayerScore1.ToString();
    }
    
    public void Score(string wallID)
    {
        
        if (wallID == "win")
        {
            PlayerScore1++;
            Debug.Log("New Score Player = " + PlayerScore1);
            UpdateScore();
            
            
        }
        else if(wallID == "Loose")
        {
            PlayerScore2++;
            Debug.Log("New Score Player = " + PlayerScore2);
            UpdateScore();
        }
        pongBall.RestartGame();
    }

    
}
