using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CommandProcessor))]
public class GameManager : MonoBehaviour, IEntity
{
    private CommandProcessor comProc;

    void Awake(){
        comProc = GetComponent<CommandProcessor>();
    }

    public void ResetGame(){
        var reset = new ResetCommand(this);
        comProc.ExecuteCommand(reset);
    }

    public void ResetBall(){
        var resBall = new ResBallCom(this);
        comProc.ExecuteCommand(resBall);
    }

    public void IncrementScore(Text toIncrement){
        int score = int.Parse(toIncrement.text);
        score ++;
        toIncrement.text = "" + score;
    }
}
