using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;
    private int player_score = 0;
    private int bot_score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 9.3f)
        {
            player_score = player_score + 1;
        }
        if (ball.transform.position.x <= -9.3f)
        {
            bot_score = bot_score + 1;
        }
        Scoreboard.text = player_score.ToString() + " - " + bot_score.ToString();
        print(player_score + " , " + bot_score);
    }
}
