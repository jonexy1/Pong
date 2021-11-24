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
    private float speed = 40.0f;
    private Transform target;
    private float x = 0f;
    private float diffMod = 0.1f;
    public bool isHard = false;
    public bool isMedium = false;
    public bool isEasy = true;


    public float AIMovement(){
        
        if(!ball){
            ball = GameObject.FindGameObjectWithTag("Ball");
        }
        ballPos = ball.transform.localPosition;

        if(isEasy == true){
            diffMod = 0.6f;
            }

        if(isMedium == true){
            isEasy = false;
            diffMod = 0.4f;
            }

        if(isHard == true){
            isEasy = false;
            isMedium = false;
            diffMod = 0.2f;
        }


        if((go.transform.position.x > leftBound) && ballPos.x < go.transform.position.x && (go.transform.position.x - ballPos.x) >= diffMod){
            return x =  -speed;
        }

        if((go.transform.position.x < rightBound) && ballPos.x > go.transform.position.x && (ballPos.x - go.transform.position.x) >= diffMod){

            return x  = speed;
        }
        return x = 0f;
    }
}
