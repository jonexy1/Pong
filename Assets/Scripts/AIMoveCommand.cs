using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveCommand : MonoBehaviour
{
    private GameObject ball;
    private float leftBound = -8.264982f;
    private float rightBound = 8.264982f;
    public GameObject go;
    private Vector2 ballPos;
    private float distMoved = 0.0001f;


    public Vector3 AIMovement(){
        
        if(!ball){
            ball = GameObject.FindGameObjectWithTag("Ball");
        }
        ballPos = ball.transform.localPosition;

        if((go.transform.position.x > leftBound) && (ballPos.x < go.transform.position.x)){

            return new Vector3(-distMoved, 0 ,0);
        }

        if((go.transform.position.x < rightBound) && (ballPos.x > go.transform.position.x)){

            return new Vector3(distMoved, 0, 0);
        }
        return Vector3.zero;
    }
}
