using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIMoveCommand : MonoBehaviour
{
    private GameObject ball;
    private float leftBound = -8.16f;
    private float rightBound = 8.16f;
    public GameObject go;
    private Vector2 ballPos;
    private float speed = 50.0f;
    private Transform target;
    private float x = 0f;
    private float diffMod = 9.0f;
    public bool isHard = false;
    public bool isMedium = false;
    public bool isEasy = true;


    public float AIMovement(){
        
        if(!ball){
            ball = GameObject.FindGameObjectWithTag("Ball");
        }
        ballPos = ball.transform.localPosition;

        if(isEasy == true){
            diffMod = 6.0f;
            }

        if(isMedium == true){
            isEasy = false;
            diffMod = 8.0f;
            }

        if(isHard == true){
            isEasy = false;
            isMedium = false;
            diffMod = 9.0f;
        }


        if((go.transform.position.x > leftBound) && ballPos.x < go.transform.position.x && (Mathf.Abs(ball.transform.position.y - go.transform.position.y )) <= diffMod){
            return x =  -speed;
        }

        if((go.transform.position.x < rightBound) && ballPos.x > go.transform.position.x && (Mathf.Abs(ball.transform.position.y - go.transform.position.y )) <= diffMod){

            return x  = speed;
        }
        return x = 0f;
    }
}
