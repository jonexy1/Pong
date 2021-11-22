using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCommand : Command
{
    private GameObject ball;
    private GameObject[] ent;
    private GameObject[] computer;

    public ResetCommand(IEntity entity): base(entity){
        ball = GameObject.FindGameObjectWithTag("Ball");
        ent = GameObject.FindGameObjectsWithTag("Player");
        computer = GameObject.FindGameObjectsWithTag("Computer");
    }


    public override void Execute(){
        ball.GetComponent<BallMovement>().ResetBall();
        for(int i = 0; i < computer.Length; i++){
            computer[i].GetComponent<Computer>().ResetComputer();
        }

        for(int i = 0; i < ent.Length; i++){
            ent[i].GetComponent<Entity>().ResetEntity();
        }
    }
}
