using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    protected IEntity _entity;

    public Command(IEntity entity){
        _entity = entity;
    }

    public abstract void Execute();
}
