using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMovement : MonoBehaviour
{
    //public Vector2 ballDirection = Vector2.up;

    private float moveSpeed = 15f;
    private int randBounce;
    public Vector2 ballDirection;
    private Vector3 startPos;


    void Awake(){
        startPos = gameObject.transform.position;
    }


    // Start is called before the first frame update
    void Start()
    {

        int randY = Random.Range(0,2);
        
        if(randY == 0){
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -moveSpeed);
        } else if(randY == 1){
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
    }

    public void ResetBall(){
        transform.position = startPos;
        Start();
    }
}
