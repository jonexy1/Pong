using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputReader))]
[RequireComponent(typeof(CommandProcessor))]
public class Entity : MonoBehaviour, IEntity
{
    private InputReader iRead;
    private CommandProcessor comProc;
    private Vector3 startPos; 

    
    private void Awake(){
        iRead = GetComponent<InputReader>();
        comProc = GetComponent<CommandProcessor>();

        startPos = gameObject.transform.position;
    }

    void FixedUpdate(){
        var direction = iRead.ReadInput();
        if(direction != Vector3.zero){
            var moveCommand = new MoveCommand(this, direction);
            comProc.ExecuteCommand(moveCommand);
        }
    }

    public void ResetEntity(){
        gameObject.transform.position = startPos;
    }
}
