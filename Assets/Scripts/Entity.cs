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
    private Rigidbody2D rb;

    
    private void Awake(){
        iRead = GetComponent<InputReader>();
        comProc = GetComponent<CommandProcessor>();
        rb = GetComponent<Rigidbody2D>();

        startPos = gameObject.transform.position;
    }

    void FixedUpdate(){
        var direction = iRead.ReadInput();
        var moveCommand = new MoveCommand(this, rb, direction);
        comProc.ExecuteCommand(moveCommand);

    }

    public void ResetEntity(){
        gameObject.transform.position = startPos;
        Debug.Log(startPos);
    }
}
