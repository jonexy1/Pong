using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public GameObject gm;
    public GameObject ballSpawner;
    public Text player1Score;
    public Text player2Score;
    public GameObject go;


    void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "Ball"){
            if(gameObject.tag =="Player 1 Goal"){
                gm.gameObject.GetComponent<GameManager>().IncrementScore(player2Score);
                ballSpawner.gameObject.GetComponent<BallSpawner>().SpawnBall();

            }else if(gameObject.tag == "Player 2 Goal"){
                gm.gameObject.GetComponent<GameManager>().IncrementScore(player1Score);
                ballSpawner.gameObject.GetComponent<BallSpawner>().SpawnBall();
            }
        }
    }
}
