using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AIMoveCommand))]
[RequireComponent(typeof(CommandProcessor))]
public class Computer : MonoBehaviour, IEntity
{
    
    private CommandProcessor comProc;
    private AIMoveCommand comDirection;
    private Vector3 startPos;

    
    private void Awake(){
        comDirection = GetComponent<AIMoveCommand>();
        comProc = GetComponent<CommandProcessor>();
        startPos = gameObject.transform.position;
    }

    void FixedUpdate()
    {
        var direction = comDirection.AIMovement();
        if(direction != Vector3.zero){
            var moveCommand = new MoveCommand(this, direction);
            comProc.ExecuteCommand(moveCommand);
        }
    }

    public void ResetComputer(){
        gameObject.transform.position = startPos;
    }
}