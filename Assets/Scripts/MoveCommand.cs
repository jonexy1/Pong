using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    private float speed;
    public float dist = .1f;
    private Rigidbody2D _rb2D;
    private Vector3 vel = Vector3.zero;
    float smoothVal = 0.01f;


    public MoveCommand(IEntity entity, Rigidbody2D  rb2D,  float direction) : base(entity){
        speed = direction;
        _entity = entity;
        _rb2D = rb2D;
    }

    public override void Execute(){
        Vector3 dir = new Vector3(speed * dist, 0, 0);
        if(speed == 0 && _rb2D.velocity.magnitude < .01){
            _rb2D.velocity = vel;
        } else{
            _rb2D.velocity = Vector3.SmoothDamp(_rb2D.velocity, dir, ref vel, smoothVal);
        }
        
    }
}
