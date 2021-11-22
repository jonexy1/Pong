using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    //public Vector2 ballDirection = Vector2.up;

    private float moveSpeed = 5f;
    private int randBounce;
    public Vector2 ballDirection;
    private Vector3 startPos;
    public GameManager gm;
    public Text player1Score;
    public Text player2Score;

    void Awake(){
        startPos = gameObject.transform.position;
    }


    // Start is called before the first frame update
    void Start()
    {

        int rand = Random.Range(0,2);
        if(rand == 0){
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -moveSpeed);
        } else if(rand == 1){
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, moveSpeed);
        }
        
    }

    void Update(){
        randBounce = Random.Range(-6,6);
        ballDirection = (Vector2)this.transform.position;
    }


    void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "Paddle"){

            if(this.transform.position.y > 0){
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(randBounce, -moveSpeed);

            } else{
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(randBounce, moveSpeed);
            }
        }

        if(other.gameObject.tag == "Player 1 Goal"){
            gm.gameObject.GetComponent<GameManager>().IncrementScore(player2Score);
            gm.gameObject.GetComponent<GameManager>().ResetGame();
        }

        if(other.gameObject.tag == "Player 2 Goal"){
            gm.gameObject.GetComponent<GameManager>().IncrementScore(player1Score);
            gm.gameObject.GetComponent<GameManager>().ResetGame();
        }
    }

    public void ResetBall(){
        transform.position = startPos;
        Start();
    }
}
