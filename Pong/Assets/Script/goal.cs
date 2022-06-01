using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class goal : MonoBehaviour
{
    public TextMeshProUGUI Scoreboard;
    private float player_score = 0;
    private float bot_score = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "ball")
        {
            player_score = player_score + 1;
            Scoreboard.text = player_score + (" - ").ToString();
            Destroy(other.gameObject);
        }
        //private void OnCollisionEnter2D(Collision2D collision)
        //{
        // bot_score = bot_score + 1;
        //Scoreboard.text = player_score.ToString() + " - " + bot_score.ToString();
        //print(player_score + " , " + bot_score);
        // Destroy(GameObject.FindWithTag("ball"));
        // }
    } 
}
