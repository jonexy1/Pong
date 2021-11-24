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
    private Rigidbody2D rb;

    
    private void Awake(){
        comDirection = GetComponent<AIMoveCommand>();
        comProc = GetComponent<CommandProcessor>();
        rb = GetComponent<Rigidbody2D>();
        startPos = gameObject.transform.position;
    }

    void FixedUpdate()
    {
        var direction = comDirection.AIMovement();
        if(direction != 0){
            var moveCommand = new MoveCommand(this, rb, direction);
            comProc.ExecuteCommand(moveCommand);
        }
    }

    public void ResetComputer(){
        gameObject.transform.position = startPos;
    }
}