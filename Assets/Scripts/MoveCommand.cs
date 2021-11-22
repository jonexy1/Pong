using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    private Vector3 _direction;
    public float speed = 1.0f;

    public MoveCommand(IEntity entity, Vector3 direction) : base(entity){
        _direction = direction;
    }

    public override void Execute(){
        _entity.transform.position += _direction * speed;
    }
}
