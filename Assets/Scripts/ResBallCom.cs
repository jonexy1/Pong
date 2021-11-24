using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResBallCom : Command
{
    private GameObject ball;


    public ResBallCom(IEntity entity): base(entity){
        ball = GameObject.FindGameObjectWithTag("Ball");
    }


    public override void Execute(){
        ball.GetComponent<BallMovement>().ResetBall();
    }
}