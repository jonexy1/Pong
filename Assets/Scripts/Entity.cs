using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputReader))]
[RequireComponent(typeof(CommandProcessor))]
public class Entity : MonoBehaviour, IEntity
{
    private InputReader iRead;
    private CommandProcessor comProc;
    
    private void Awake(){
        iRead = GetComponent<InputReader>();
        comProc = GetComponent<CommandProcessor>();
    }

    void Update()
    {
        var direction = iRead.ReadInput();
        if(direction != Vector3.zero){
            var moveCommand = new MoveCommand(this, direction);
            comProc.ExecuteCommand(moveCommand);
        }
    }
}
