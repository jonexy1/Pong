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
    public bool isHard = false;
    private float difMod = 0.1f;


    public Vector3 AIMovement(){
        if(isHard == true){
            difMod = 0.2f;
        }

        if(isHard == false){
            difMod = 0.05f;
        }
        

        if(!ball){
            ball = GameObject.FindGameObjectWithTag("Ball");
        }
        ballPos = ball.transform.localPosition;

        if((go.transform.position.x > leftBound) && (ballPos.x < go.transform.position.x)){

            return new Vector3(-difMod, 0 ,0);
        }

        if((go.transform.position.x < rightBound) && (ballPos.x > go.transform.position.x)){

            return new Vector3(difMod, 0, 0);
        }
        return Vector3.zero;
    }
}
